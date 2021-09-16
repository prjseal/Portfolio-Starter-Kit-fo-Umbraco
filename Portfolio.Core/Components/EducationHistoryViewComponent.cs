using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "EducationHistory")]
    public class EducationHistoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IWorkHistoryControls educationHistoryControls)
        {
            var model = new EducationHistoryViewModel(educationHistoryControls);
            return View(model);
        }
    }
}
