using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using DataAccessLayer.Context;

namespace DataAccessLayer.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private MyElectricShopContext _context;
        public CategoryRepository(MyElectricShopContext context)
        {
            _context = context;
        }

        public  IEnumerable<Category> GetAllCategories()
        {
            return _context.categories;
        }

        public Category GetCategoryById(int id)
        {
            return _context.categories.FirstOrDefault(i => i.CategoryId == id);
        }
        public void CreateCategory(Category category)
        {
            _context.Add(category);
        }

        public void EditCategory(Category category)
        {
            _context.Update(category);
        }
        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public bool CategoryExist(int id)
        {
           return  _context.categories.Any(i => i.CategoryId == id);
        }
    }
}
