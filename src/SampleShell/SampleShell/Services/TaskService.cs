using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleShell.Models;

namespace SampleShell.Services
{
    public class TaskService
    {
        private Dictionary<string, SampleTask> _tasks;
        public Dictionary<string, SampleTask> Tasks => _tasks;

        public async Task<bool> CompleteTask(string title)
        {
            SampleTask tmp;
            var res = _tasks.TryGetValue(title, out tmp);
            if (!res) return await Task.FromResult(false);
            tmp.Status = Models.TaskStatus.Completed;
            return await Task.FromResult(true);
        }

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
            return await Task.FromResult(true);
        }
    }
}
