using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "TopNavigation")]
    public class TopNavigationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IPublishedContent model)
        {
            var homePage = model.AncestorOrSelf<Home>();
            var pages = homePage?.Children() ?? Enumerable.Empty<IPublishedContent>();

            var vm = new TopNavigationViewModel()
            {
                HomePage = homePage,
                NavigationItems = pages
            };

            return View(vm);
        }
    }
}
