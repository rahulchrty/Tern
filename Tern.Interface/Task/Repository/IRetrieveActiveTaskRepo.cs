using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IRetrieveActiveTaskRepo
    {
        Task<List<TaskModel>> GetActiveTasks();
    }
}
