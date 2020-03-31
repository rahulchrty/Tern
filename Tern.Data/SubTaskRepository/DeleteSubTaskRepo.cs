using System.Threading.Tasks;
using Tern.Domain;
using Tern.Interface.SubTask;

namespace Tern.Data.SubTaskRepository
{
    public class DeleteSubTaskRepo : IDeleteSubTaskRepo
    {
        private TernContext _ternContext;
        public DeleteSubTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> Delete(int subTaskId)
        {
            int rowAffected = 0;
            SubTask subTask = new SubTask {SubTaskId = subTaskId };
            _ternContext.SubTasks.Attach(subTask);
            _ternContext.SubTasks.Remove(subTask);
            rowAffected += await _ternContext.SaveChangesAsync();
            return rowAffected;
        }
    }
}
