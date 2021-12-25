using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Repository;

namespace News.Components
{
    public class ShowTopPagesViewComponent : ViewComponent
    {
        IPageRepository _pageRepository;
        public ShowTopPagesViewComponent(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowTopPages", _pageRepository.GetTopPage()));

        }
    }
}
