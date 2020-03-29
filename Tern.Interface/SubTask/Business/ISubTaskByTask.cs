using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface ISubTaskByTask
    {
        Task<List<SubTaskModel>> GetSubTask(int taskId);
    }
}
