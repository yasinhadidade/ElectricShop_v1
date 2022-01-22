using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyElectricShop.Components
{
    public class SliderComponent:ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public SliderComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/SliderComponent.cshtml", _productRepository.GetAllProducts());
        }
    }
}
