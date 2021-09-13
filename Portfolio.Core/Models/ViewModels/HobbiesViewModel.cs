using Umbraco.Cms.Core.Strings;

namespace Portfolio.Core.Models.ViewModels
{
    public class HobbiesViewModel
    {
        public HobbiesViewModel(CV cv)
        {
            Hobbies = cv.Hobbies;
            HobbiesTitle = cv.HobbiesTitle;
        }

        public IHtmlEncodedString Hobbies { get; set; }
        public string HobbiesTitle { get; set; }
    }
}
