using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Context;
using DataAccessLayer.Models;

namespace DataAccessLayer.Services
{
    public class ContentRepository : IContentRepository
    {
        private readonly MyElectricShopContext _context;
        public ContentRepository(MyElectricShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Content> GetAllContents()
        {
            return _context.contents;
        }

        public Content GetContentById(int id)
        {
            return _context.contents.FirstOrDefault(i => i.Contentid == id);
        }
        public void CreateContent(Content content)
        {
            _context.contents.Add(content);
        }
        public void EditContent(Content content)
        {
            _context.contents.Update(content);
        }
        public void DeleteContent(Content content)
        {
            _context.contents.Remove(content);
        }
        public bool ContentExist(int id)
        {
            return _context.contents.Any(i => i.Contentid == id);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Content> Last3Contents()
        {
            return _context.contents.OrderByDescending(i => i.CreateDate).Take(3);
        }

        public IEnumerable<Content> MostVisitedContent()
        {
            return _context.contents.OrderByDescending(i => i.visit).Take(4);
        }

        public IEnumerable<Content> SearchedContent(string search)
        {
            return _context.contents.Where(i => i.Title.Contains(search) || i.ShortDescription.Contains(search) || i.Text.Contains(search));
        }
    }
}
