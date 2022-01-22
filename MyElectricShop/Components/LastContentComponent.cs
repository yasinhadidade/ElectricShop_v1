using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace MyElectricShop.Components
{
    public class LastContentComponent:ViewComponent
    {
        private readonly IContentRepository _contentRepository;
        public LastContentComponent(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/LastContentComponent.cshtml", _contentRepository.Last3Contents());
        }
    }
}
