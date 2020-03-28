using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IUpdateTaskRepo
    {
        Task<int> Update(TaskModel taskDetail);
    }
}
