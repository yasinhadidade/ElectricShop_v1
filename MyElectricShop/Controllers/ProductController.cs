using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using ZarinPal.Class;
using Dto.Other;
using Dto.Payment;
using Newtonsoft.Json;

namespace MyElectricShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;


        //zarrinpal variables
        //private readonly Payment _payment;
        //private readonly Authority _authority;
        //private readonly Transactions _transactions;


       static int catid;


        public ProductController(IProductRepository productRepository,
            IOrderRepository orderRepository, 
            IOrderDetailRepository orderDetailRepository,
            ICommentRepository commentRepository, 
            IUserRepository userRepository,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }

        #region ProductSinglePage
        public IActionResult ProductSinglePage(int id)
        {
            var singleproduct = _productRepository.GetProductById(id);
            if (singleproduct == null)
            {
                return RedirectToAction("Error");
            }
            ViewData["relatedproducts"] = _productRepository.GetProductsByCategoryId(singleproduct.CategoryId);
            ViewData["cms"] = _commentRepository.GetCommentsByProductId(id);

            return View(singleproduct);
        }
        #endregion

        public IActionResult ShowAllProducts()
        {
            var products = _productRepository.GetAllProducts().ToList();
            ViewData["categories"] = _categoryRepository.GetAllCategories();
            ViewData["TopSales"] = _productRepository.BestSales();

            return View(products);
        }

        #region Cart
        [Authorize]
        public IActionResult AddToCart(int productid, int count)
        {
            var product = _productRepository.GetProductById(productid);
            if (product != null)
            {
                int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
                var order = _orderRepository.GetOrderByuserId(userid);

                if (order != null && order.IsFinally==false)
                {

                   var orderdetail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        ProductId = product.ProductId,
                        Price = product.Price,
                        Count = count,
                        CreateDate=DateTime.Now,
                        Isfinally = false
                    };
                    _orderDetailRepository.CreateOrderDetail(orderdetail);
                    _orderDetailRepository.save();
                }
                else if(order==null)
                {
                    order = new Order()
                    {
                        IsFinally = false,
                        CreateDate = DateTime.Now,
                        UserId = userid

                    };
                    _orderRepository.CreateOrder(order);
                    _orderRepository.save();

                    OrderDetail od = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        ProductId = product.ProductId,
                        Price = product.Price,
                        Count = count,
                        CreateDate=DateTime.Now,
                        Isfinally=false
                    };
                    _orderDetailRepository.CreateOrderDetail(od);
                    _orderDetailRepository.save();
                }
            }
            return RedirectToAction("ShowCart");

        }


        [Authorize]
        public IActionResult ShowCart()
        {

            int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            var order = _orderRepository.GetOrderForShowCartByUserId(userid);
            
            if (order != null && order.orderDetails != null)
            {
                order.Sum = _orderDetailRepository.GetAllOrderDetailsByOrderId(order.OrderId).Where(i=>i.Isfinally==false).Sum(i => i.Count * i.Price);
                _orderRepository.save();
            }

           
            return View(order);
        }
        #endregion

        #region RemoveOrderDetail
        [Authorize]
        [Route("/product/RemoveCart/{detailid}")]
        public IActionResult RemoveCart(int detailid)
        {
            var orderdetail = _orderDetailRepository.GetOrderDetailByDetailId(detailid);
            _orderDetailRepository.RemoveOrderDetail(orderdetail);
            _orderDetailRepository.save();
            return RedirectToAction("ShowCart");

        }
        #endregion

        [HttpPost]
        public IActionResult Search(string search)
        {
            var searchedpro = _productRepository.GetSearchedProducts(search);
            
            ViewBag.searchtitle = search;
            return View(searchedpro);
        }

        #region comment
        public IActionResult AddComment(int productid, string name, string email, string text)
        {
            var comment = new Comment()
            {
                Productid = productid,
                Name = name,
                Email = email,
                CommentText = text,

            };
            _commentRepository.AddComment(comment);
            _commentRepository.save();
            ViewData["cms"] = _commentRepository.GetCommentsByProductId(productid);
            return PartialView();

        }
        #endregion

        [Route("/product/ShowProductsOfSomeCategory/{categoryid}")]
        public IActionResult ShowProductsOfSomeCategory(int categoryid)
        {
            var products = _productRepository.GetProductsByCategoryId(categoryid);
            //return PartialView(products);
            ViewData["categories"] = _categoryRepository.GetAllCategories();
            ViewData["TopSales"] = _productRepository.BestSales();

            catid = categoryid;
            return View("ShowAllProducts", products);
        }


        public IActionResult buytest(int id)
        {
            var order = _orderRepository.GetOrderByOrderid(id);
            //var orderdetails = _orderDetailRepository.GetAllOrderDetails().Where(i => i.OrderId == id && i.Isfinally == false);
            var orderdetails = order.orderDetails.Where(i => i.Isfinally == false);
            foreach(var item in orderdetails)
            {
               var product= _productRepository.GetProductById(item.ProductId);
                product.TotalNumberOfSales += item.Count;
                _productRepository.save();
                
            }
            
            order.CreateDate = DateTime.Now;
            order.IsFinally = true;
            _orderRepository.save();
            return Content("payment is done bro");
        }

        #region filtering the products

        public IActionResult filter(string test)
        {
           if(catid!=0)
            {
                if (test == "1")
                {
                    var products = _productRepository.GetAllProducts().Where(i => i.CategoryId == catid).OrderByDescending(i => i.Price);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "2")
                {
                    var products = _productRepository.GetAllProducts();
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "3")
                {
                    var products = _productRepository.GetAllProducts().Where(i => i.CategoryId == catid).OrderByDescending(i => i.CreateDate);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "4")
                {
                    var products = _productRepository.GetAllProducts().Where(i => i.CategoryId == catid).OrderBy(i => i.Price);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "5")
                {
                    var products = _productRepository.GetAllProducts().Where(i => i.CategoryId == catid).OrderByDescending(i => i.TotalNumberOfSales);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
               
            }
           else
            {
                if (test == "1")
                {
                    var products = _productRepository.GetAllProducts().OrderByDescending(i => i.Price);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "2")
                {
                    var products = _productRepository.GetAllProducts();
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "3")
                {
                    var products = _productRepository.GetAllProducts().OrderByDescending(i => i.CreateDate);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "4")
                {
                    var products = _productRepository.GetAllProducts().OrderBy(i => i.Price);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
                else if (test == "5")
                {
                    var products = _productRepository.GetAllProducts().OrderByDescending(i => i.TotalNumberOfSales);
                    return PartialView("ShowProductsOfSomeCategory", products);
                }
            }
            return Content("xx");
        }
        #endregion


        #region Error404

        public IActionResult Error()
        {
            return View();
        }
        #endregion
    }
}
