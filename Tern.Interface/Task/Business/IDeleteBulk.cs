using System.Threading.Tasks;

namespace Tern.Interface.Task
{
    public interface IDeleteBulk
    {
        Task<int> Delete(int[] taskIds);
    }
}
