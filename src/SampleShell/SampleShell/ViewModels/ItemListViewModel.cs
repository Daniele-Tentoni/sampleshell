using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using SampleShell.Models;
using SampleShell.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SampleShell.ViewModels
{
    public class ItemListViewModel : BaseViewModel
    {
        private TaskService service = DependencyService.Get<TaskService>();

        private ObservableCollection<SampleTask> _sampletasks;
        public ObservableCollection<SampleTask> SampleTasks
        {
            get => _sampletasks;
            set => SetProperty(ref _sampletasks, value);
        }

        public ItemListViewModel()
        {
            _sampletasks = new ObservableCollection<SampleTask>();
            LoadSampleTasksCommand = new Command(async () => await ExecuteLoadSampleTasks());
        }

        public ICommand LoadSampleTasksCommand { get; }

        private async Task ExecuteLoadSampleTasks()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var tmp = service.Tasks.Values;
                if (tmp.Any())
                {
                    SampleTasks = new ObservableCollection<SampleTask>(tmp);
                }
                else
                {
#if DEBUG
                    await Device.InvokeOnMainThreadAsync(async () => await Application.Current.MainPage.DisplayAlert("Tasks", "No tasks", "Bad"));
#endif
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
