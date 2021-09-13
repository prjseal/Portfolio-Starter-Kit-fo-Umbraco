namespace Portfolio.Core.Models.ViewModels
{
    public class SkillsViewModel
    {
        public SkillsViewModel(IWorkHistoryControls skillsControls)
        {
            SkillsControls = skillsControls;
        }

        public IWorkHistoryControls SkillsControls { get; set; }
    }
}
