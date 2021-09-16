using Umbraco.Cms.Web.Common.PublishedModels;

namespace Portfolio.Core.Models.ViewModels
{
    public class FooterViewModel
    {
        public FooterViewModel(IFooterControls footerControls)
        {
            FooterControls = footerControls;
        }

        public IFooterControls FooterControls { get; set; }
    }
}
