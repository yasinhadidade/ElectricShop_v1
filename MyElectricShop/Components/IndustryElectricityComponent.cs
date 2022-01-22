using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Components
{
    public class IndustryElectricityComponent: ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public IndustryElectricityComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pro = _productRepository.GetProductsByCategoryId(3);
            return View("/Views/Shared/Components/IndustryElectricityComponent.cshtml", pro);
        }
    }
}
