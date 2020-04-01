using System.Threading.Tasks;

namespace Tern.Interface.List
{
    public interface IDeleteList
    {
        bool isDeleteAllTasks { get; }
        Task<int> Delete(int listId);
    }
}
