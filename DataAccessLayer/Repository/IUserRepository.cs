using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
   public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByUserId(int id);
        void CreateUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);
        bool IsExistByUserId(int id);
        void save();

        //to find the exact user that wanna login 
        User GetUserForLogin(string email, string password);

        //to make sure if email for registeration of a new client is already existed or not
        bool IsExistUserByEmail(string email);

        //to fill the table of new orders (سفارشات جدید)
        IEnumerable<User> GetUsersWithFinallyOrder();

    }
}
