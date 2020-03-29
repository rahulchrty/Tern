using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IUpdateTask
    {
        Task<int> Update(TaskModel taskDetail);
    }
}
