﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;
using Portfolio.Core.Models.ViewModels;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "AvatarHeader")]
    public class AvatarHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IProfileControls profileControls, bool borderBottom)
        {
            var model = new AvatarHeaderViewModel(profileControls, borderBottom);

            return View(model);
        }
    }
}