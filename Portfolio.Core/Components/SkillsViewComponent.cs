using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "Skills")]
    public class SkillsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IWorkHistoryControls skillsControls)
        {
            var model = new SkillsViewModel(skillsControls);
            return View(model);
        }
    }
}
