using System.Threading.Tasks;

namespace Tern.Interface.SubTask
{
    public interface IDeleteSubTask
    {
        Task<int> Delete(int[] subTaskId);
    }
}
