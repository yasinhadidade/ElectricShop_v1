using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;

namespace MyElectricShop.Components
{
    public class NewAddedProductComponent:ViewComponent
    {
        private IProductRepository _productRepository;
        public NewAddedProductComponent(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/NewAddedProductComponent.cshtml", _productRepository.New4AddedProduct());
        }
    }
}
