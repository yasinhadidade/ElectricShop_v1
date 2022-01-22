using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private  MyElectricShopContext _context;
        public UserRepository(MyElectricShopContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.users.Include(i => i.order);
        }
        public User GetUserByUserId(int id)
        {
            return _context.users.Include(i=>i.order).ThenInclude(i=>i.orderDetails).ThenInclude(i=>i.product).FirstOrDefault(i => i.UserId == id);
        }
        public void CreateUser(User user)
        {
            _context.users.Add(user);

        }
        public void EditUser(User user)
        {
            _context.users.Update(user);
        }

        public void DeleteUser(User user)
        {
            _context.users.Remove(user);
        }
        public bool IsExistByUserId(int id)
        {
            return _context.users.Any(i => i.UserId == id);
        }

        public void save()
        {
            _context.SaveChanges();
        }



        public User GetUserForLogin(string email, string password)
        {
            return _context.users.SingleOrDefault(s => s.Email == email && s.Password == password);
        }

        public bool IsExistUserByEmail(string email)
        {
            return _context.users.Any(i => i.Email == email);
        }

        public IEnumerable<User> GetUsersWithFinallyOrder()
        {
            return _context.users.Include(i => i.order).Where(i => i.order.IsFinally == true);
        }
    }
}
