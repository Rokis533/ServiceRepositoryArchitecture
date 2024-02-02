using ServiceRepositoryArchitecture.Helpers;
using ServiceRepositoryArchitecture.Repositories.Interfaces;
using ServiceRepositoryArchitecture.Repositories;
using ServiceRepositoryArchitecture.Services;
using ServiceRepositoryArchitecture.Services.Interfaces;

namespace ServiceRepositoryArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITaskRepository taskRepository = new TaskRepository();
            ITaskService taskService = new TaskService(taskRepository);
            ConsoleUI ui = new ConsoleUI(taskService);

            ui.Run();
        }
    }
}
