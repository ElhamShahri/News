using News.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Models;

namespace News.Repository
{
    public interface IPageGroupRepository
    {
        List<PageGroup> GetAllPageGroups();
        PageGroup GetPageGroupById(int groupId);
        void InsertPageGroup(PageGroup pageGroup);
        void UpdatePageGroup(PageGroup pageGroup);
        void DeletePageGroup(PageGroup pageGroup);
        void DeletePageGroup(int groupId);
        bool PageGroupExists(int groupId);
        List<ShowGroupsViewModel> GetListGroups();
        void Save();
       
     }
}
