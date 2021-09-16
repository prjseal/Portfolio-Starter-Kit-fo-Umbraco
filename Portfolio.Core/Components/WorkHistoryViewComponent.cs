using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "WorkHistory")]
    public class WorkHistoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IWorkHistoryControls workHistoryControls)
        {
            var model = new WorkHistoryViewModel(workHistoryControls);
            return View(model);
        }
    }
}
