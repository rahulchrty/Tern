using System.Threading.Tasks;

namespace Tern.Interface.List
{
    public interface IDeleteOnlyListRepo
    {
        Task<int> DeleteList(int listId);
    }
}
