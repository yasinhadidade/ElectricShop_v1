using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SoldProductsController : Controller
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        public SoldProductsController(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public IActionResult Index()
        {
            var orderdetails = _orderDetailRepository.GetSoldProductsOrderDetails();
            return View(orderdetails);
        }

        //public IActionResult regularSoldProducts()
        //{
        //    _orderDetailRepository.ge
        //}
    }
}
