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

        private bool _fingerprintLogin;
        public bool FingerprintLogin
        {
            get => _fingerprintLogin;
            set
            {
                OnPropertyChanged(nameof(FingerprintLogin));
                _fingerprintLogin = value;
                Preferences.Set(PreferencesStrings.FingerprintLogin, value);
            }
        }

        public SettingsViewModel()
        {
            _fingerprintLogin = Preferences.Get(PreferencesStrings.FingerprintLogin, false);
        }

        private async Task ExecuteLogout() => await Shell.Current.GoToAsync("//login");
    }
}
