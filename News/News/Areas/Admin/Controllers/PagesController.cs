using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Repository;
using News.Web.Models;

namespace News.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        //public PagesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        public IPageRepository _pageRepository;
        public IPageGroupRepository _pageGroupRepository;
        public PagesController(ApplicationDbContext context, IPageRepository pageRepository, IPageGroupRepository pageGroupRepository)
        {
            _context = context;
            _pageRepository = pageRepository;
            _pageGroupRepository = pageGroupRepository;
        }

        // GET: Admin/Pages
        public async Task<IActionResult> Index()
        {
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");
            return View(_pageRepository.GetAllPage());
        }

        // GET: Admin/Pages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);

            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET: Admin/Pages/Create
        public IActionResult Create()
        {
            //ViewData["GroupID"] = new SelectList(_context.PageGroups, "GroupID", "GroupTitle");
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");
            return View();
        }

        // POST: Admin/Pages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageID,GroupID,PageTitle,ShortDescription,PageText,PageVisit,ImageName,PageTags,ShowInSlider,CreateDate")] Page page,IFormFile imgup)
        {
            if (ModelState.IsValid)
            {
                page.PageVisit = 0;
                page.CreateDate = DateTime.Now;
                //ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");
                //ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");

                if (imgup != null)
                {
                    //page.ImageName = imgup.FileName;
                    //page.ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgup.FileName);
                    //string savePath = Path.Combine(
                    //    Directory.GetCurrentDirectory(), "wwwroot/PageImages"
                    //    );

                    //using (var stream = new FileStream(savePath, FileMode.Create))
                    //{
                    //    await imgup.CopyToAsync(stream);
                    //}
                    var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgup.FileName);
                    page.ImageName = ImageName;
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PageImages");
                    var filePath = Path.Combine(dir, page.ImageName);

                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imgup.CopyToAsync(fileStream);
                    }
                }

               // _context.Add(page);
               //await _context.SaveChangesAsync();
                _pageRepository.InsertPage(page);
               _pageRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");
            return View(page);
        }

        // GET: Admin/Pages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);
            ViewData["GroupID"] = new SelectList(_pageGroupRepository.GetAllPageGroups(), "GroupID", "GroupTitle");

            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageID,GroupID,PageTitle,ShortDescription,PageText,PageVisit,ImageName,PageTags,ShowInSlider,CreateDate")] Page page, IFormFile imgup)
        {
            if (id != page.PageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (imgup != null)
                    {
                        if (page.ImageName == null)
                        {
                            var ImageName = Guid.NewGuid().ToString() + Path.GetExtension(imgup.FileName);
                            page.ImageName = ImageName;
                        }

                        var dir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PageImages");
                        var filePath = Path.Combine(dir, page.ImageName);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await imgup.CopyToAsync(fileStream);
                        }
                    }

                    //_context.Update(page);
                    //await _context.SaveChangesAsync();
                    _pageRepository.UpdatePage(page);
                    _pageRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageID))
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
            return View(page);
        }

        // GET: Admin/Pages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = _pageRepository.GetPageById(id.Value);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var page = _pageRepository.GetPageById(id);
            _pageRepository.DeletePage(page);

            if (page.ImageName != null)
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PageImages",page.ImageName);
            if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }
            _pageRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return _pageRepository.PageExists(id);
        }
    }
}
