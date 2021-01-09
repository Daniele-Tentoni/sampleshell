using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using SampleShell.Models;
using SampleShell.Services;
using Xamarin.Forms;

namespace SampleShell.ViewModels
{
    /// <summary>
    /// ViewModel for ItemListPage.
    /// </summary>
    public class ItemListViewModel : BaseViewModel
    {
        private readonly TaskService service;

        public ObservableCollection<SampleTask> SampleTasks
        {
            get => new ObservableCollection<SampleTask>(service.Tasks.Values);
        }

        public ItemListViewModel()
        {
            service = DependencyService.Get<TaskService>();
            LoadSampleTasksCommand = new Command(async () => await ExecuteLoadSampleTasks());
            CreateSampleTaskCommand = new Command(async () => await ExecuteCreateSampleTask());
        }

        public ICommand LoadSampleTasksCommand { get; }

        public ICommand CreateSampleTaskCommand { get; }

        /// <summary>
        /// Execute the load tasks command. Use recursion to retry the loading.
        /// </summary>
        /// <returns>Load task completition.</returns>
        private async Task ExecuteLoadSampleTasks()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                await LoadTasks();
            }
            finally
            {
                IsBusy = false;
            }
        }

        /// <summary>
        /// Ask the user to input the task title and persist it.
        /// </summary>
        /// <returns>Persist task completition.</returns>
        private async Task ExecuteCreateSampleTask()
        {
            if (IsBusy) return;
            IsBusy = true;

            try
            {
                var title = await Device.InvokeOnMainThreadAsync(async () =>
                await Application.Current.MainPage.DisplayPromptAsync(
                    "Tasks",
                    "Prompt task title"));
                if (!string.IsNullOrEmpty(title))
                {
                    var res = await service.CreateTask(title);
                    // Notify view to update each observer of SampleTasks property.
                    OnPropertyChanged(nameof(SampleTasks));
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

        /// <summary>
        /// Load persisted tasks to observable property.
        /// </summary>
        /// <returns>Load task completition.</returns>
        private async Task LoadTasks()
        {
            var tmp = service.Tasks.Values;
            if (tmp.Any())
            {
                OnPropertyChanged(nameof(SampleTasks));
            }
            else
            {
#if DEBUG
                // Advice and create the first default task.
                var advice = Device.InvokeOnMainThreadAsync(async () => await Application.Current.MainPage.DisplayAlert("Tasks", "No tasks", "Bad"));
                var creation = service.CreateTask("First Task");
                await Task.WhenAll(advice, creation);
                await LoadTasks();
#endif
            }
        }
    }
}
