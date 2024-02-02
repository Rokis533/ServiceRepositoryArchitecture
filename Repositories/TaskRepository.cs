using ServiceRepositoryArchitecture.Models;
using ServiceRepositoryArchitecture.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly List<JobTask> _tasks = new();

        public JobTask GetTask(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<JobTask> GetAllTasks()
        {
            return _tasks;
        }

        public void AddTask(JobTask task)
        {
            _tasks.Add(task);
        }

        public void UpdateTask(JobTask task)
        {
            var index = _tasks.FindIndex(t => t.Id == task.Id);
            if (index != -1)
            {
                _tasks[index] = task;
            }
        }

        public void DeleteTask(int id)
        {
            _tasks.RemoveAll(t => t.Id == id);
        }
    }
}
