using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;
using News.Repository;
using News.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Service
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private ApplicationDbContext _db;
        public PageGroupRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void DeletePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Deleted;
        }

        public void DeletePageGroup(int groupId)
        {
            var group = GetPageGroupById(groupId);
            DeletePageGroup(group);
        }

        public List<PageGroup> GetAllPageGroups()
        {
            return _db.PageGroups.ToList();
        }

        public List<ShowGroupsViewModel> GetListGroups()
        {
            return _db.PageGroups.Select(g => new ShowGroupsViewModel()
            {
                GroupID= g.GroupID,
                GroupTitle= g.GroupTitle,
                PageCount=g.Pages.Count

            }).ToList();
        }

        public PageGroup GetPageGroupById(int groupId)
        {
            return _db.PageGroups.Find(groupId);
        }

        public void InsertPageGroup(PageGroup pageGroup)
        {
            _db.PageGroups.Add(pageGroup);
        }

        public bool PageGroupExists(int groupId)
        {
            return _db.PageGroups.Any(p => p.GroupID == groupId);
        }

        public void Save()
        {
           _db.SaveChanges();
        }

        public void UpdatePageGroup(PageGroup pageGroup)
        {
            _db.Entry(pageGroup).State = EntityState.Modified;
        }
    }
}
