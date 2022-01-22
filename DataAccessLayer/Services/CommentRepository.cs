using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;

namespace DataAccessLayer.Services
{

    
    public class CommentRepository : ICommentRepository
    {
        private readonly MyElectricShopContext _context;
        public CommentRepository(MyElectricShopContext context)
        {
            _context = context;
        }
        public void AddComment(Comment comment)
        {
            _context.comments.Add(comment);
            
        }

        public IEnumerable<Comment> GetCommentsByProductId(int id)
        {
            return _context.comments.Where(i => i.Productid == id);
        }

        public void save()
        {
            _context.SaveChanges();
        }
    }
}
