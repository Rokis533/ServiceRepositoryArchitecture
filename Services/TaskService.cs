using ServiceRepositoryArchitecture.Repositories;
using ServiceRepositoryArchitecture.Repositories.Interfaces;
using ServiceRepositoryArchitecture.Models;
using ServiceRepositoryArchitecture.Services.Interfaces;
using ServiceRepositoryArchitecture.Helpers;

namespace ServiceRepositoryArchitecture.Services
{
    internal class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public void AddTask(string title)
        {
            if (!ValidationUtility.IsValidTaskTitle(title))
            {
                ConsoleLogger.Log("Invalid task title. Task was not added.");
                return;
            }

            var task = new JobTask { Title = title, IsCompleted = false };
            _repository.AddTask(task);
            ConsoleLogger.Log($"Task added: {title}");
        }

        public IEnumerable<JobTask> GetAllTasks()
        {
            return _repository.GetAllTasks();
        }

        public void CompleteTask(int id)
        {
            var task = _repository.GetTask(id);
            if (task != null)
            {
                task.IsCompleted = true;
                _repository.UpdateTask(task);
            }
        }
    }
}
