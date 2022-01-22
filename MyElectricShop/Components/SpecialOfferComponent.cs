using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MyElectricShop.Components
{
    public class SpecialOfferComponent : ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public SpecialOfferComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/SpecialOfferComponent.cshtml", _productRepository.GetAllSpecialProducts());
        }


    }
}
