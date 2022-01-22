using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FinallyOrdersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private IOrderDetailRepository _orderDetailRepository;

        public FinallyOrdersController(IUserRepository userRepository, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
        {
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        public IActionResult Index()
        {

            return View(_userRepository.GetUsersWithFinallyOrder().ToList());
        }

        public IActionResult ShowOrderOfUser(int id)
        {
            var order = _orderRepository.GetOrderForShowCartByUserId(id);
            var orderdetails = order.orderDetails.Where(i => i.Isfinally == false).ToList();
            var user = _userRepository.GetUserByUserId(id);
            ViewBag.name = user.Fulllname;
            return PartialView(orderdetails);
        }

        //[Route("/admin/finallyorders/OpenOrder/{userid}")]
        public string OpenOrder(int userid)
        {
            var order = _orderRepository.GetOrderByuserId(userid);
            order.IsFinally = false;
            _orderRepository.save();
            return "فاکتور مشتری مورد نظر با موفقیت باز شد";

        }

        //[Route("/admin/finallyorders/finishorderdetail/{detailid}")]
        public string finishorderdetail(int detailid)
        {
            var orderdetail = _orderDetailRepository.GetOrderDetailByDetailId(detailid);
            orderdetail.Isfinally = true;
            orderdetail.CreateDate = DateTime.Now;
            _orderDetailRepository.save();
            return "ریز فاکتور مورد نظر در بایگانی با موفقیت ذخیره شد";

        }
    }
}
