using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface ICommentRepository
    {

        void AddComment(Comment comment);
        IEnumerable<Comment> GetCommentsByProductId(int id);
        void save();
    }
}
