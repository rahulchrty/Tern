using System.Linq;
using Tern.Domain;
using Tern.Interface.Task;

namespace Tern.Data.TaskRepository
{
    public class TaskStatusRepo : ITaskStatusRepo
    {
        private TernContext _ternContext;
        public TaskStatusRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int UpdateStatus(int taskId, int statusId)
        {
            int rowAffected = 0;
            Task task = _ternContext.Tasks.FirstOrDefault(x => x.TaskId == taskId);
            if (task != null)
            {
                task.StatusId = statusId;
                _ternContext.Tasks.Update(task);
                rowAffected = _ternContext.SaveChanges();
            }
            return rowAffected;
        }
    }
}
