using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IOrderDetailRepository
    {
        //to create the orderdetail of a cient that wanna buy sth
        void CreateOrderDetail(OrderDetail orderDetail);

        //to remove an OrderDetail by client && to close an OrderDetail to keep it in dead records
        OrderDetail GetOrderDetailByDetailId(int id);

        //To show us the order details of a client that his order is paid
        IEnumerable<OrderDetail> GetAllOrderDetailsByOrderId(int id);
        void RemoveOrderDetail(OrderDetail orderDetail);

        //to fill the dead records table
        IEnumerable<OrderDetail> GetSoldProductsOrderDetails();

        //still nothing
        IEnumerable<OrderDetail> GetAllOrderDetailsByProductId(int productid);

        IEnumerable<OrderDetail> GetAllOrderDetails();

        void save();
    }
}
