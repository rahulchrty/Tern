using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Data.TaskRepository
{
    public class UpdateTaskRepo : IUpdateTaskRepo
    {
        private TernContext _ternContext;
        public UpdateTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> Update(TaskModel taskDetail)
        {
            int recordAffected = 0;
            Domain.Task task = _ternContext.Tasks.AsNoTracking().FirstOrDefault(x => x.TaskId == taskDetail.TaskId);
            if (task != null)
            {
                task.TaskName = taskDetail.TaskName;
                task.Description = taskDetail.Description;
                task.ListId = taskDetail.List.ListId;
                task.StatusId = taskDetail.Status.StatusId;
                _ternContext.Tasks.Update(task);
                recordAffected = await _ternContext.SaveChangesAsync();
            }
            return recordAffected;
        }
    }
}
