using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "Hobbies")]
    public class HobbiesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CV cv)
        {
            var model = new HobbiesViewModel(cv);

            return View(model);
        }
    }
}
