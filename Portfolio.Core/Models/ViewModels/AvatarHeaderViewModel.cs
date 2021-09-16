using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace Portfolio.Core.Models.ViewModels
{
    public class AvatarHeaderViewModel
    {
        public AvatarHeaderViewModel(IProfileControls profileControls, bool borderBottom)
        {
            AboutMe = profileControls.AboutMe;
            Avatar = profileControls.Avatar;
            ProfileLink = profileControls.ProfileLink;
            BorderBottom = borderBottom;
        }

        public IHtmlEncodedString AboutMe { get; set; }
        public IPublishedContent Avatar { get; set; }
        public Link ProfileLink { get; set; }
        public bool BorderBottom { get; set; }
    }
}
