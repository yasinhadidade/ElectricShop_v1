using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services
{
    public class OrderRepository : IOrderRepository
    {
        private MyElectricShopContext _context;
        public OrderRepository(MyElectricShopContext context)
        {
            _context = context;
        }
        public void CreateOrder(Order order)
        {
            _context.orders.Add(order);
        }

        public Order GetOrderByOrderid(int id)
        {
            return _context.orders.Include(i=>i.orderDetails).FirstOrDefault(i=>i.OrderId==id);
        }

        public Order GetOrderByuserId(int id)
        {
           return _context.orders.FirstOrDefault(i => i.UserId == id);
        }

        //important method
        public Order GetOrderForShowCartByUserId(int userid)
        {
            return  _context.orders.Where(i => i.UserId == userid).Include(i => i.orderDetails).ThenInclude(i => i.product).FirstOrDefault();
        }
         
        
        public void save()
        {
            _context.SaveChanges();
        }
    }
}
