using App.Infrastructure;

namespace App.ViewModels.Account
{
    public class LogOutViewModel : BaseViewModel
    {
        public string LogOffReturnTOUrl { get; set; }

        public override void Load()
        {
            base.Load();
            LogOffReturnTOUrl = "https://www.facs.org";
        }
    }
}