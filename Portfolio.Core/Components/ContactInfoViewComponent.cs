using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "ContactInfo")]
    public class ContactInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IWorkHistoryControls contactInfoControls)
        {
            var model = new ContactInfoViewModel(contactInfoControls);
            return View(model);
        }
    }
}
