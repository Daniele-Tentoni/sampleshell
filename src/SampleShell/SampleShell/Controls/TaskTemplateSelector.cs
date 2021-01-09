using SampleShell.Models;
using Xamarin.Forms;

namespace SampleShell.Controls
{
    public class TaskTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CompletedTask { get; set; }
        public DataTemplate UncompletedTask { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((SampleTask)item).Status.Equals(TaskStatus.Completed) ? CompletedTask : UncompletedTask;
        }
    }
}
