using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    public class PageGroupsController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public PageGroupsController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public IPageGroupRepository _pageGroupRepository;

        public PageGroupsController(IPageGroupRepository pageGroupRepository)
        {
            _pageGroupRepository = pageGroupRepository;
        }

        // GET: Admin/PageGroups
        public async Task<IActionResult> Index()
        {
            //return View(await _context.PageGroups.ToListAsync());
            return View(_pageGroupRepository.GetAllPageGroups());
        }

        // GET: Admin/PageGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var pageGroup = await _context.PageGroups
            //    .FirstOrDefaultAsync(m => m.GroupID == id);


            var pageGroup = _pageGroupRepository.GetPageGroupById(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }

            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/PageGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(pageGroup);
                //await _context.SaveChangesAsync();
                _pageGroupRepository.InsertPageGroup(pageGroup);
                _pageGroupRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var pageGroup = await _context.PageGroups.FindAsync(id);
            var pageGroup =  _pageGroupRepository.GetPageGroupById(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }
            return View(pageGroup);
        }

        // POST: Admin/PageGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (id != pageGroup.GroupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(pageGroup);
                    //await _context.SaveChangesAsync();
                    _pageGroupRepository.UpdatePageGroup(pageGroup);
                    _pageGroupRepository.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageGroupExists(pageGroup.GroupID))
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
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var pageGroup = await _context.PageGroups
            //    .FirstOrDefaultAsync(m => m.GroupID == id);

            var pageGroup = _pageGroupRepository.GetPageGroupById(id.Value);
            if (pageGroup == null)
            {
                return NotFound();
            }

            return View(pageGroup);
        }

        // POST: Admin/PageGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var pageGroup = await _context.PageGroups.FindAsync(id);
            //_context.PageGroups.Remove(pageGroup);
            //await _context.SaveChangesAsync();
        
            _pageGroupRepository.DeletePageGroup(id);
            _pageGroupRepository.Save();
            return RedirectToAction(nameof(Index));
        }

        private bool PageGroupExists(int id)
        {
            return _pageGroupRepository.PageGroupExists(id);
        }
    }
}
