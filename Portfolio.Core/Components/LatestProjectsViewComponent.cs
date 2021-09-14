using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Models;
using Umbraco.Extensions;

namespace Portfolio.Core.Components
{
    [ViewComponent(Name = "LatestProjects")]
    public class LatestProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ProjectList projectList)
        {
            var projects = projectList != null ? projectList.Children<Project>() : Enumerable.Empty<Project>();

            return View(projects);
        }
    }
}
