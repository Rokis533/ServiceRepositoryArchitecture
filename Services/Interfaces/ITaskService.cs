using ServiceRepositoryArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture.Services.Interfaces
{
    public interface ITaskService
    {
        public void AddTask(string title);
        IEnumerable<JobTask> GetAllTasks();
        void CompleteTask(int id);
    }
}
