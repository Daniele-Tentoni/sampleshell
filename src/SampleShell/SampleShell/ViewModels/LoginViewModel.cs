namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using SampleShell.Resources.Strings;
    using SampleShell.Resources.Strings.Login;
    using System.Threading.Tasks;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand => new Command(async () => await ExecuteLogin());

        // TODO: Here you have to add credentials 
        private async Task ExecuteLogin() => await NextPage();

        /// <summary>
        /// Go to next page with Shell apis.
        /// </summary>
        /// <returns>Task to complete.</returns>
        private async Task NextPage() => await Shell.Current.GoToAsync("//about");
    }
}
