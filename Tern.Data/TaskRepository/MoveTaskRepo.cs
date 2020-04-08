using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tern.Domain;
using Tern.Interface.Task;

namespace Tern.Data.TaskRepository
{
    public class MoveTaskRepo : IMoveTaskRepo
    {
        private TernContext _ternContext;
        public MoveTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int MoveToList(int taskId, int listId)
        {
            int recordAffected = 0;
            Task task = _ternContext.Tasks.AsNoTracking().FirstOrDefault(x => x.TaskId == taskId);
            if (task != null)
            {
                task.ListId = listId;
                _ternContext.Tasks.Update(task);
                recordAffected = _ternContext.SaveChanges();
            }
            return recordAffected;
        }
    }
}
