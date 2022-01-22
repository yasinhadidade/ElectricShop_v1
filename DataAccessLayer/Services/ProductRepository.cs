using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ViewModels;

namespace DataAccessLayer.Services
{
    public class ProductRepository : IProductRepository
    {
        private MyElectricShopContext _context;
        public ProductRepository(MyElectricShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.products.Include(i => i.category);
        }

        public Product GetProductById(int id)
        {
            return _context.products.Include(i=>i.Comment).SingleOrDefault(i=>i.ProductId==id);
        }
        public void CreateProduct(Product product)
        {
            _context.products.Add(product);
        }
        public void EditProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public void DeleteProduct(Product product)
        {
            _context.products.Remove(product);
        }
        public void save()
        {
            _context.SaveChanges();
        }

        public bool ProductExist(int id)
        {
            return _context.products.Any(i => i.ProductId == id);
        }

        public ProductViewModelTest GetModelForEditPage(int id)
        {
            var product = _context.products.Include(c => c.category).Where(i => i.ProductId == id).Select(s => new ProductViewModelTest()
            {
                id = s.ProductId,
                Name = s.Name,
                Description = s.Description,
                CreateDate = s.CreateDate,
                IsSpecial = s.IsSpecial,
                IsExist = s.IsExist,
                Price = s.Price,
                ShowInSlider = s.ShowInSlider,
                CategoryId = s.CategoryId,
                OldPrice=s.OldPrice

            }).FirstOrDefault();

            return product;
        }

        public IEnumerable<Product> GetProductsByCategoryId(int id)
        {
            return _context.products.Where(i => i.CategoryId == id).ToList();

        }

        public IEnumerable<Product> GetSearchedProducts(string search)
        {
            return _context.products.Where(i => i.Name.Contains(search) || i.Description.Contains(search)).ToList();
        }

        public IEnumerable<Product> New4AddedProduct()
        {
            return _context.products.OrderByDescending(i => i.CreateDate).Take(4);
        }

        public IEnumerable<Product> GetAllSpecialProducts()
        {
            return _context.products.Where(i => i.IsSpecial == true && i.IsExist==true);
        }

        public IEnumerable<Product> BestSales()
        {
            return _context.products.OrderByDescending(i => i.TotalNumberOfSales).Take(4);
        }
    }
}
