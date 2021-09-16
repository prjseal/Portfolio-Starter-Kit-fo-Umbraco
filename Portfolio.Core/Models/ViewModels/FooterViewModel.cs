using Umbraco.Cms.Web.Common.PublishedModels;

namespace Portfolio.Core.Models.ViewModels
{
    public class FooterViewModel
    {
        public FooterViewModel(IFooterControls footerControls, string siteName)
        {
            FooterControls = footerControls;
            SiteName = siteName;
        }

        public IFooterControls FooterControls { get; set; }
        public string SiteName { get; set; }
    }
}
