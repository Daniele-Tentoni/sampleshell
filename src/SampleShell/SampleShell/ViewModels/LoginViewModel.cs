namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class LoginViewModel: BaseViewModel
    {
        public Command LoginCommand => new Command(async () => await ExecuteLogin());

        // TODO: Here you have to add credentials 
        private async Task ExecuteLogin() => await Shell.Current.GoToAsync("//about");
    }
}
