using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModels;
using DataAccessLayer.Repository;
using DataAccessLayer.Services;
using MyElectricShop.Classes;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MyElectricShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IUserRepository _userRepository;
        private IOrderRepository _orderRepository;

        public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository,IUserRepository userRepository,IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
        }

        // GET: Admin/Products
        public IActionResult Index()
        {
            int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            string email = _userRepository.GetUserByUserId(userid).Email;
            ViewBag.email = email;
            if (_userRepository.GetUsersWithFinallyOrder().Count() > 0)
            {
                ViewBag.exist = "true";
            }
            var myElectricShopContext = _productRepository.GetAllProducts().OrderByDescending(i=>i.TotalNumberOfSales);
            return View(myElectricShopContext.ToList());
            
        }

        // GET: Admin/Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryName");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProductId,CategoryId,Name,Description,Price,IsExist,Favorite,ShowInSlider")] ProductViewModelTest productvm)
        {
            if (ModelState.IsValid)
            {
                var pro = new Product()
                {
                    Name = productvm.Name,
                    Description = productvm.Description,
                    IsSpecial = productvm.IsSpecial,
                    IsExist = productvm.IsExist,
                    CreateDate = DateTime.Now,
                    ShowInSlider = productvm.ShowInSlider,
                    Price = productvm.Price,
                    CategoryId = productvm.CategoryId,
                    
                };
                _productRepository.CreateProduct(pro);
                _productRepository.save();
                if (productvm.Picture?.Length > 0)
                {
                    string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", pro.ProductId + Path.GetExtension(productvm.Picture.FileName));
                    using (var stream = new FileStream(filepath, FileMode.Create))
                    {
                        productvm.Picture.CopyTo(stream);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryId", productvm.CategoryId);
            return View(productvm);
        }

        // GET: Admin/Products/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //we introduce a variable with productviewmodeltest type to keep it in editview page 

            var product = _productRepository.GetModelForEditPage(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("id,CategoryId,Name,Description,Price,IsExist,IsSpecial,ShowInSlider")] ProductViewModelTest productvm)
        {
            if (id != productvm.id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    var product = _productRepository.GetProductById(id);
                    product.Name = productvm.Name;
                    product.Description = productvm.Description;
                    product.IsSpecial = productvm.IsSpecial;
                    product.IsExist = productvm.IsExist;
                    product.Price = productvm.Price;
                    product.ShowInSlider = productvm.ShowInSlider;
                    product.CategoryId = productvm.CategoryId;
                    // _context.Update(pro);
                    _productRepository.save();

                    if (productvm.Picture?.Length > 0)
                    {
                        string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", product.ProductId + Path.GetExtension(productvm.Picture.FileName));
                        using (var stream = new FileStream(filepath, FileMode.Create))
                        {
                            productvm.Picture.CopyTo(stream);
                        }
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(productvm.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryName", productvm.CategoryId);
            return View(productvm);
        }

        // GET: Admin/Products/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _productRepository.GetProductById(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productRepository.GetProductById(id);
            _productRepository.DeleteProduct(product);
            _productRepository.save();

            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", product.ProductId + ".jpg");
            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _productRepository.ProductExist(id);
        }
    }
}
