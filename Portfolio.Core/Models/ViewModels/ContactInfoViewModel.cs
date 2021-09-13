namespace Portfolio.Core.Models.ViewModels
{
    public class ContactInfoViewModel
    {
        public ContactInfoViewModel(IWorkHistoryControls contactInfoControls)
        {
            ContactInfoControls = contactInfoControls;
        }

        public IWorkHistoryControls ContactInfoControls { get; set; }
    }
}
