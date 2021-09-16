using Umbraco.Cms.Web.Common.PublishedModels;

namespace Portfolio.Core.Models.ViewModels
{
    public class WorkHistoryViewModel
    {
        public WorkHistoryViewModel(IWorkHistoryControls workHistoryControls)
        {
            WorkHistoryControls = workHistoryControls;
        }

        public IWorkHistoryControls WorkHistoryControls { get; set; }
    }
}
