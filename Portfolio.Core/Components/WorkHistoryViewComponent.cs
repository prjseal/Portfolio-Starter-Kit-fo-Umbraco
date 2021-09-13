using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;
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
