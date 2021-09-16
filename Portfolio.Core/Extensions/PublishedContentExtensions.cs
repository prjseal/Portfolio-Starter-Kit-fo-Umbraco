using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Portfolio.Core.Extensions
{
    public static class PublishedContentExtensions
    {
        public static string GetAltText(this IPublishedContent mediaItem)
        {
            if (mediaItem != null && mediaItem.HasProperty("altText") && mediaItem.HasValue("altText"))
            {
                return mediaItem.Value<string>("altText");
            }

            return "";
        }

        public static string GetMetaTitle(this IPublishedContent content)
        {
            if (content != null && content.HasProperty("metaTitle") && content.HasValue("metaTitle"))
            {
                return content.Value<string>("metaTitle");
            }

            return GetPageTitle(content);
        }

        public static string GetPageTitle(this IPublishedContent content)
        {
            if (content != null && content.HasProperty("title") && content.HasValue("title"))
            {
                return content.Value<string>("title");
            }

            return content.Name;
        }

        public static string GetMetaDescription(this IPublishedContent content)
        {
            if (content != null && content.HasProperty("metaDescription") && content.HasValue("metaDescription"))
            {
                return content.Value<string>("metaDescription");
            }

            return "";
        }

        public static string GetCanonicalUrl(this IPublishedContent content)
        {
            if (content != null && content.HasProperty("canonicalUrl") && content.HasValue("canonicalUrl"))
            {
                return content.Value<string>("canonicalUrl");
            }

            return content.Url(mode: UrlMode.Absolute);
        }
    }
}
