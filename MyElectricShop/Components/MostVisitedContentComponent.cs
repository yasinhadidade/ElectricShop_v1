using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MyElectricShop.Components
{
    public class MostVisitedContentComponent : ViewComponent
    {
        IContentRepository _contentRepository;
        public MostVisitedContentComponent(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/MostVisitedContentComponent.cshtml", _contentRepository.MostVisitedContent());
        }
    }
}
