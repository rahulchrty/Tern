using System.Threading.Tasks;

namespace Tern.Interface.Task
{
    public interface IDeleteTaskRepo
    {
        int Delete(int taskId);
        Task<int> DeleteAsync(int taskId);
    }
}
