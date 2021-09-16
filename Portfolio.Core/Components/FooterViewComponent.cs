using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common.PublishedModels;
using Portfolio.Core.Models.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "Footer")]
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IFooterControls footerControls)
        {
            var currentPage = (IPublishedContent)footerControls;
            var homePage = currentPage.AncestorOrSelf<Home>();

            var model = new FooterViewModel(footerControls, homePage.SiteName ?? "Portfolio");

            return View(model);
        }
    }
}
