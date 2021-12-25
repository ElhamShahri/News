using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Repository;

namespace News.Components
{
    public class ShowGroupsViewComponent:ViewComponent
    {
        IPageGroupRepository _groupRepository;
        public ShowGroupsViewComponent(IPageGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("ShowGroups",_groupRepository.GetListGroups()));
          
        }  

    }
}
