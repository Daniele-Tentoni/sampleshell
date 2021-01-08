namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class SettingsViewModel : BaseViewModel
    {
        public ICommand LogoutCommand => new Command(async () => await ExecuteLogout());

        private async Task ExecuteLogout() => await Shell.Current.GoToAsync("//login");
    }
}
