using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Components
{
    public class CategoriesComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesComponent(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View("/Views/Shared/Components/CategoriesComponent.cshtml", _categoryRepository.GetAllCategories());
        }
    }
}
