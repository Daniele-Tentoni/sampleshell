using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MonkeyCache.FileStore;
using SampleShell.Models;

namespace SampleShell.Services
{
    public class TaskService
    {
        private Dictionary<string, SampleTask> _tasks;
        public Dictionary<string, SampleTask> Tasks => _tasks;

        public TaskService()
        {
            _tasks = Barrel.Current.Get<Dictionary<string, SampleTask>>("tasks") ?? new Dictionary<string, SampleTask>();
        }

        public Task<bool> Persist()
        {
            Barrel.Current.Add("tasks", _tasks, TimeSpan.FromDays(10));
            return Task.FromResult(Barrel.Current.Exists("tasks"));
        }

        /// <summary>
        /// Complete a specified task.
        /// </summary>
        /// <param name="title">Title of the task to complete.</param>
        /// <returns>Completition completed.</returns>
        public async Task<bool> CompleteTask(string title)
        {
            SampleTask tmp;
            var res = _tasks.TryGetValue(title, out tmp);
            if (!res) return await Task.FromResult(false);
            tmp.Status = Models.TaskStatus.Completed;
            return await Persist();
        }

        /// <summary>
        /// Create a new task.
        /// </summary>
        /// <param name="title">Title of the task to create.</param>
        /// <returns>Creation completed.</returns>
        public async Task<bool> CreateTask(string title)
        {
            if (_tasks.ContainsKey(title)) return await Task.FromResult(false);
            var tmp = new SampleTask
            {
                CreationDate = DateTime.Now,
                Status = Models.TaskStatus.Created,
                SubTitle = title + title,
                Title = title
            };
            _tasks.Add(title, tmp);
            return await Persist();
        }
    }
}
