using SampleShell.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleShell.Views.Browse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsListPage : ContentPage
    {
        private readonly ItemListViewModel _viewModel;
        public ItemsListPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (_viewModel?.SampleTasks?.Count == 0)
                _viewModel.LoadSampleTasksCommand.Execute(null);
        }
    }
}