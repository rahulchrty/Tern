using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface ICreateSubTask
    {
        Task<int> Create(CreateSubTaskModel subTask);
    }
}
