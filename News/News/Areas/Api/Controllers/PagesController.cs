using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using News.Web.Models;

namespace News.Areas.Api.Controllers
{
    [Route("api/pages")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        ApplicationDbContext _db;
        public PagesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pages = _db.Pages.ToList();
            return Ok(pages);
        }

        [HttpGet("{id}", Name = "GetPage")]
        public IActionResult Get(int id)
        {
            var page = _db.Pages.Find(id);
            return Ok(page);
        }
        [HttpPost]
        public IActionResult Create(Page page)
        {
            if (ModelState.IsValid)
            {
                _db.Pages.Add(page);
                _db.SaveChanges();
                return CreatedAtRoute("GetPage", new { id = page.PageID }, page);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Page page)
        {
            var p = _db.Pages.Find(id);
            p.PageTitle = page.PageTitle;
            p.PageID = page.PageID;
            p.GroupID = page.GroupID;
            p.PageTitle = page.PageTitle;
            p.ShortDescription = page.ShortDescription;
            p.PageVisit = page.PageVisit;
            p.ImageName = page.ImageName;
            p.PageTags = page.PageTags;
            p.ShowInSlider = page.ShowInSlider;
            p.CreateDate = page.CreateDate;
            _db.Pages.Update(p);
            _db.SaveChanges();
            return CreatedAtRoute("GetPerson", new { id = id }, p);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var page = _db.Pages.Find(id);
            _db.Pages.Remove(page);
            _db.SaveChanges();
            return NoContent();
        }

    }
}
