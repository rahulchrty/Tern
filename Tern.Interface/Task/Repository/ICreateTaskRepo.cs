using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface ICreateTaskRepo
    {
        Task<int> CreateNewTask(CreateTaskModel taskDetail);
    }
}
