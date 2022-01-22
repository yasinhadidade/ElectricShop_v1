using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MyElectricShop.Components
{
    public class MinerProductComponent:ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public MinerProductComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pro = _productRepository.GetProductsByCategoryId(1);
            return View("/Views/Shared/Components/MinerProductComponent.cshtml", pro);
        }
    }
}
