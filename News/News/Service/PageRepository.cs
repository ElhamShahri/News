using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Repository;
using News.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Service
{
    public class PageRepository : IPageRepository
    {
        public ApplicationDbContext _db;
        public PageRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void DeletePage(Page page)
        {
            _db.Entry(page).State = EntityState.Deleted;
        }

        public void DeletePage(int pageId)
        {
            var page = GetPageById(pageId);
            DeletePage(page);
        }

        public List<Page> GetAllPage()
        {
            return _db.Pages.ToList();
        }

        public IEnumerable<Page> GetLatesPage()
        {
            return _db.Pages.OrderByDescending(p => p.CreateDate).Take(4).ToList();
        }

        public Page GetPageById(int pageId)
        {
            return _db.Pages.Find(pageId);
        }

        public IEnumerable<Page> GetPagesByGroup(int groupId)
        {
            return _db.Pages.Where(p => p.pageGroup.GroupID == groupId).ToList();
        }

        public IEnumerable<Page> GetPagesInSlider()
        {
            return _db.Pages.Where(p => p.ShowInSlider).ToList();
        }

        public IEnumerable<Page> GetTopPage(int take=4)
        {
            return _db.Pages.OrderByDescending(p => p.PageVisit).Take(take).ToList();
        }

        public void InsertPage(Page page)
        {
            _db.Pages.Add(page);
        }

        public bool PageExists(int id)
        {
            return _db.Pages.Any(p => p.PageID == id);
        }
        public void Save()
        {
           _db.SaveChanges();
        }

        public IEnumerable<Page> Search(string q)
        {
            var list = _db.Pages.Where(p => p.PageTitle.Contains(q) ||
            p.ShortDescription.Contains(q) || p.PageText.Contains(q) || 
            p.PageTags.Contains(q));
            return list.Distinct().ToList();
        }

        public void UpdatePage(Page page)
        {
            _db.Entry(page).State = EntityState.Modified;
        }


    }
}
