using System;
namespace SampleShell.Models
{
    public enum TaskStatus
    {
        Created,
        Approved,
        Failed,
        Completed
    }

    public class SampleTask
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public TaskStatus Status { get; set; }
    }
}
