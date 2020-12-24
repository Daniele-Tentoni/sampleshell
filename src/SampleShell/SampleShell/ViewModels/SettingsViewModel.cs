namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using SampleShell.Resources.Strings;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class SettingsViewModel : BaseViewModel
    {
        public ICommand LogoutCommand => new Command(async () => await ExecuteLogout());

        public bool FingerprintLogin
        {
            get => Preferences.Get(PreferencesStrings.FingerprintLogin, false);
            set
            {
                OnPropertyChanged(nameof(FingerprintLogin));
                Preferences.Set(PreferencesStrings.FingerprintLogin, value);
            }
        }

        private async Task ExecuteLogout() => await Shell.Current.GoToAsync("//login");
    }
}
