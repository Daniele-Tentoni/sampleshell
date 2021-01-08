using SampleShell.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleShell.Views.Browse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsListPage : ContentPage
    {
        public ItemsListPage()
        {
            InitializeComponent();
            BindingContext = new ItemListViewModel();
        }
    }
}