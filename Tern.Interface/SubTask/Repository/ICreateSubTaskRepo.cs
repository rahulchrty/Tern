using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface ICreateSubTaskRepo
    {
        Task<int> Create(CreateSubTaskModel subTask);
    }
}
