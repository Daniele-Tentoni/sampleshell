namespace SampleShell
{
    using SampleShell.Services;
    using Xamarin.Forms;

    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Give as soon as possible a task service singleton.
            DependencyService.Register<TaskService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
