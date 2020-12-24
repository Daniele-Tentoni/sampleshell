namespace SampleShell.Views.Login
{
    using SampleShell.ViewModels;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly LoginViewModel _viewModel;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LoginViewModel();
        }

        protected override void OnAppearing()
        {
            if (_viewModel?.FingerPrintLogin ?? false)
            {
                _viewModel?.FingerPrintLoginCommand?.Execute(null);
            }
        }
    }
}