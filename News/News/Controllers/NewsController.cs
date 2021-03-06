using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using News.Repository;

namespace News.Controllers
{
    public class NewsController : Controller
    {
        IPageRepository _pageRepository;
        public NewsController(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        [Route("News/{newsId}")]
        public IActionResult ShowNews(int newsId)
        {
            var page = _pageRepository.GetPageById(newsId);
            if (page != null)
            {
                page.PageVisit += 1;
                _pageRepository.UpdatePage(page);
                _pageRepository.Save();

            }
            return View(page);
        }
        [Route("Group/{groupId}/{title}")]
        public IActionResult ShowNewsByGroupId(int groupId, string title)
        {
            ViewData["GroupTitle"] = title;
            return View(_pageRepository.GetPagesByGroup(groupId));
        }
        [Route("Search")]
       public IActionResult Search(string q)
        {
            return View(_pageRepository.Search(q));
        }
    }
}
