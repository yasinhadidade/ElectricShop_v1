using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MyElectricShop.Components
{
    public class BuildingElectricityComponent : ViewComponent
    {
        private readonly IProductRepository _productRepository;
        public BuildingElectricityComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pro = _productRepository.GetProductsByCategoryId(2);

            return View("/Views/Shared/Components/BuildingElectricityComponent.cshtml", pro);
        }
    }
}
