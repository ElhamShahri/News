using News.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Repository
{
    public interface IPageRepository
    {
        List<Page> GetAllPage();
        IEnumerable<Page> GetTopPage(int take = 4);
        IEnumerable<Page> GetPagesInSlider();
        IEnumerable<Page> GetLatesPage();
        IEnumerable<Page> GetPagesByGroup(int groupId);
        IEnumerable<Page> Search(string q);
        Page GetPageById(int pageId);
        void InsertPage(Page page);
        void UpdatePage(Page page);
        void DeletePage(Page page);
        void DeletePage(int pageId);
        bool PageExists(int id);
        void Save();


    }
}
