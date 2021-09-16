using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Portfolio.Core.Models.ViewModels
{
    public class TopNavigationViewModel
    {
        public IPublishedContent HomePage { get; set; }
        public IEnumerable<IPublishedContent> NavigationItems { get; set; }
        public string SiteName { get; set; }
    }
}
