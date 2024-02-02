using ServiceRepositoryArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRepositoryArchitecture.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        JobTask GetTask(int id);
        IEnumerable<JobTask> GetAllTasks();
        void AddTask(JobTask task);
        void UpdateTask(JobTask task);
        void DeleteTask(int id);
    }
}
