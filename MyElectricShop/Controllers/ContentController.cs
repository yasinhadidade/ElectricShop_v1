using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using DataAccessLayer.Models;

namespace MyElectricShop.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentRepository _contentRepository;
        private readonly ICommentRepository _commentRepository;

        public ContentController(IContentRepository contentRepository,ICommentRepository commentRepository)
        {
            _contentRepository = contentRepository;
            _commentRepository =commentRepository;
        }

        public IActionResult ShowAllContents()
        {
            var contents = _contentRepository.GetAllContents();
            return View(contents);
        }
        [Route("/content/ContentSinglePage/{contentid}")]
        public IActionResult ContentSinglePage(int contentid)
        {
            var content = _contentRepository.GetContentById(contentid);
            if(content==null)
            {
                return NotFound();
            }
            content.visit += 1;
            _contentRepository.save();
            return View(content);
        }

        [HttpPost]
        public IActionResult SearchedContent(string search)
        {
            ViewBag.searchtitle = search;
            return View(_contentRepository.SearchedContent(search));

        }

        [Route("/content/SearchedContenttags/{search}")]
        public IActionResult SearchedContenttags(string search)
        {
            ViewBag.searchtitle = search;
            return View("SearchedContent", _contentRepository.SearchedContent(search));

        }




    }
}
