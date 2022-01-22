using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public interface IOrderRepository
    {
        //to create order for new client
        void CreateOrder(Order order);

        //to check if order is null or not in order to decide creating new order or not && to open client order after sending them sold products
        Order GetOrderByuserId(int id);

        //To show client their bascket
        Order GetOrderForShowCartByUserId(int userid);

        //get order of user to check it for payment
        Order GetOrderByOrderid(int id);

        void save();
    }
}
