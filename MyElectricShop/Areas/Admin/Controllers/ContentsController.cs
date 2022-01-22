using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace MyElectricShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContentsController : Controller
    {
        private IContentRepository _contentRepository;
        public ContentsController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        // GET: Admin/Contents
        public IActionResult Index()
        {
            return View(_contentRepository.GetAllContents().ToList());
        }

        // GET: Admin/Contents/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = _contentRepository.GetContentById(id.Value);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        // GET: Admin/Contents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Contentid,Title,ShortDescription,Text,Tags,Author")] Content content)
        {
            if (ModelState.IsValid)
            {
                content.CreateDate = DateTime.Now;
                content.visit = 0;
                _contentRepository.CreateContent(content);
                _contentRepository.save();
                return RedirectToAction(nameof(Index));
            }
            return View(content);
        }

        // GET: Admin/Contents/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = _contentRepository.GetContentById(id.Value);
            if (content == null)
            {
                return NotFound();
            }
            return View(content);
        }

        // POST: Admin/Contents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Contentid,Title,ShortDescription,Text,visit,CreateDate,Tags,Author")] Content content)
        {
            if (id != content.Contentid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _contentRepository.EditContent(content);
                    _contentRepository.save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentExists(content.Contentid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(content);
        }

        // GET: Admin/Contents/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = _contentRepository.GetContentById(id.Value);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        // POST: Admin/Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var content = _contentRepository.GetContentById(id);
            _contentRepository.DeleteContent(content);
            _contentRepository.save();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentExists(int id)
        {
            return _contentRepository.ContentExist(id);
        }
    }
}
