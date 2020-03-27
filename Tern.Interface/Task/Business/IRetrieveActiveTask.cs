using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IRetrieveActiveTask
    {
        Task<List<TaskModel>> GetActiveTasks();
    }
}
