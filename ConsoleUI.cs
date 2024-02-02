using ServiceRepositoryArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture
{
    public class ConsoleUI
    {
        private readonly ITaskService _taskService;
        public ConsoleUI(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Task Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List All Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ListTasks();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        private void AddTask()
        {
            Console.Write("Enter the title of the task: ");
            var title = Console.ReadLine();
            _taskService.AddTask(title);
            Console.WriteLine("Task added successfully.");
            Console.ReadKey();
        }

        private void ListTasks()
        {
            var tasks = _taskService.GetAllTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"Task ID: {task.Id}, Title: {task.Title}, Completed: {task.IsCompleted}");
            }
            Console.ReadKey();
        }

        private void CompleteTask()
        {
            Console.Write("Enter the ID of the task to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int taskId))
            {
                _taskService.CompleteTask(taskId);
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task ID.");
            }
            Console.ReadKey();
        }
    }

}
