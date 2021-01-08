namespace SampleShell.ViewModels
{
    using MvvmHelpers;
    using Plugin.Fingerprint;
    using Plugin.Fingerprint.Abstractions;
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
        private async Task ExecuteLogin() => await NextPage();

        // TODO: Here you control if have permissions.
        private async Task ExecuteFingerPrintLogin()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                /*
                 * Before this you have to acquire the current activity in
                 * Android CurrentActivity from James Montemagno.
                 * See MainActivity code.
                 */
                var request = new AuthenticationRequestConfiguration(
                    "Prove you have fingers!",
                    "Because without it you can't have access");
                var result = await CrossFingerprint.Current.AuthenticateAsync(request);
                if (result.Authenticated)
                {
                    /*
                     * Make here secret stuffs like change page.
                     */
                    await Device.InvokeOnMainThreadAsync(async () =>
                    await Application.Current.MainPage.DisplayAlert(
                        "Authentication", "You are authenticated", "Ok"));
                    await NextPage();
                }
                else
                {
                    /*
                     * Say to user that is not allowed to make secret stuffs.
                     */
                    await Device.InvokeOnMainThreadAsync(async () =>
                    await Application.Current.MainPage.DisplayAlert(
                        "Authentication", "You aren't authenticated", "Bad"));
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

        /// <summary>
        /// Go to next page with Shell apis.
        /// </summary>
        /// <returns>Task to complete.</returns>
        private async Task NextPage() => await Shell.Current.GoToAsync("//about");
    }
}
