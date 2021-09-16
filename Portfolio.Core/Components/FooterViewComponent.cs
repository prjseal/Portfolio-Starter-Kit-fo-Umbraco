using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "Footer")]
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IFooterControls footerControls)
        {
            var model = new FooterViewModel(footerControls);
            return View(model);
        }
    }
}
