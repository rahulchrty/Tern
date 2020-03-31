using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface ISubTaskByTaskRepo
    {
        Task<List<SubTaskModel>> GetSubTask(int taskId);
    }
}
