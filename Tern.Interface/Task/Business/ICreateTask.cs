using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface ICreateTask
    {
        Task<int> CreateNewTask(CreateTaskModel taskDetail);
    }
}
