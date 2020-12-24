namespace SampleShell.Views.Settings
{
    using SampleShell.ViewModels;
    using System;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        private readonly SettingsViewModel viewModel;

        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SettingsViewModel();
        }

        private async Task Picker_SelectedIndexChanged(object sender, EventArgs e) => await Device.InvokeOnMainThreadAsync(async () => await Application.Current.MainPage.DisplayAlert("Language", "Selected italian language.", "Ok"));
    }
}