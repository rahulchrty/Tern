using System.Threading.Tasks;

namespace Tern.Interface.List
{
    public interface IDeleteListWithTaskRepo
    {
        Task<int> DeleteListWithAllTask(int listId);
    }
}
