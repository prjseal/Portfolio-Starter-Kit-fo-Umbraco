using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "Hobbies")]
    public class HobbiesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CV cv)
        {
            var model = new HobbiesViewModel(cv);

            return View(model);
        }
    }
}
