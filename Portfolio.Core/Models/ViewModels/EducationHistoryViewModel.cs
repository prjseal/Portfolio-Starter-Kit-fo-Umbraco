namespace Portfolio.Core.Models.ViewModels
{
    public class EducationHistoryViewModel
    {
        public EducationHistoryViewModel(IWorkHistoryControls educationHistoryControls)
        {
            EducationHistoryControls = educationHistoryControls;
        }

        public IWorkHistoryControls EducationHistoryControls { get; set; }
    }
}
