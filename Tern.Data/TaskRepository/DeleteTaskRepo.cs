using System.Threading.Tasks;
using Tern.Interface.Task;

namespace Tern.Data.TaskRepository
{
    public class DeleteTaskRepo : IDeleteTaskRepo
    {
        private TernContext _ternContext;
        public DeleteTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int Delete(int taskId)
        {
            Domain.Task task = new Domain.Task { TaskId = taskId};
            _ternContext.Tasks.Attach(task);
            _ternContext.Tasks.Remove(task);
            int rowAffected = _ternContext.SaveChanges();
            return rowAffected;
        }

        public async Task<int> DeleteAsync(int taskId)
        {
            Domain.Task task = new Domain.Task { TaskId = taskId };
            _ternContext.Tasks.Attach(task);
            _ternContext.Tasks.Remove(task);
            int rowAffected = await _ternContext.SaveChangesAsync();
            return rowAffected;
        }
    }
}
