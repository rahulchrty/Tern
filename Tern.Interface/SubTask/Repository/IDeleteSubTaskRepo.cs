using System.Threading.Tasks;

namespace Tern.Interface.SubTask
{
    public interface IDeleteSubTaskRepo
    {
        Task<int> Delete(int subTaskId);
    }
}
