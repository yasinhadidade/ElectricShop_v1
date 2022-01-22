using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Components
{
    public class CategoriesInMiddleComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesInMiddleComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View("/Views/Shared/Components/CategoriesInMiddleComponent.cshtml", _categoryRepository.GetAllCategories());
        }
    }
}
