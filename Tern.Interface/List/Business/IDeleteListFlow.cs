using System.Threading.Tasks;

namespace Tern.Interface.List
{
    public interface IDeleteListFlow
    {
        Task<int> Delete(int listId, bool isDeleteAllTasks);
    }
}
