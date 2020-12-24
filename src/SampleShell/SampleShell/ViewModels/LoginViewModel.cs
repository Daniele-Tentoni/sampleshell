namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using SampleShell.Resources.Strings;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        public bool FingerPrintLogin => Preferences.Get(PreferencesStrings.FingerprintLogin, false);

        public Command LoginCommand => new Command(async () => await ExecuteLogin());

        public Command FingerPrintLoginCommand => new Command(async () => await ExecuteFingerPrintLogin());

        // TODO: Here you have to add credentials 
        private async Task ExecuteLogin() => await Shell.Current.GoToAsync("//about");

        private async Task ExecuteFingerPrintLogin()
        {

        }
    }
}
