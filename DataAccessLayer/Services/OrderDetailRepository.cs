using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Services
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private MyElectricShopContext _context;
            public OrderDetailRepository(MyElectricShopContext context)
        {
            _context = context;
        }
        public void CreateOrderDetail(OrderDetail orderDetail)
        {
            _context.orderDetails.Add(orderDetail);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetailsByOrderId(int id)
        {
            return _context.orderDetails.Where(i => i.OrderId == id);
        }

        public OrderDetail GetOrderDetailByDetailId(int id)
        {
            return _context.orderDetails.FirstOrDefault(i => i.DetailId == id);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetailsByProductId(int productid)
        {
            return _context.orderDetails.Where(i => i.ProductId == productid);
        }

        public IEnumerable<OrderDetail> GetSoldProductsOrderDetails()
        {
            return _context.orderDetails.Include(i => i.product).Where(i => i.Isfinally == true).OrderByDescending(i => i.CreateDate).ToList();

        }

        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            _context.orderDetails.Remove(orderDetail);
        }

        public void save()
        {
            _context.SaveChanges();
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _context.orderDetails;
        }
    }
}
