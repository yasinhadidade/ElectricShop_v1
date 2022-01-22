using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyElectricShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository,IOrderRepository orderRepository,IProductRepository productRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            // int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            string userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(userid!=null)
            {
                var order = _orderRepository.GetOrderForShowCartByUserId(int.Parse(userid));
                if(order!=null)
                {
                    string count = order.orderDetails.Where(i => i.Isfinally == false).ToList().Count.ToString();
                    ViewBag.c = count;
                }
               
            }


            //int userid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
            //var user = _userRepository.GetUserByUserId(userid);
            //if (user==null)
            //{
            //    return View();

            //}
            //else
            //{
            //    ViewBag.isadmin = user.IsAdmin.ToString();

            //}
            string isadmin = User.FindFirstValue(ClaimTypes.Role);
            ViewBag.isadmin = isadmin;

            return View();

        }
      


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
