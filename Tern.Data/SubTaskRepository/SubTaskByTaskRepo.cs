using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Data.SubTaskRepository
{
    public class SubTaskByTaskRepo : ISubTaskByTaskRepo
    {
        private TernContext _ternContext;
        public SubTaskByTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<List<SubTaskModel>> GetSubTask(int taskId)
        {
            var searchedSubTask = await (from subTask in _ternContext.SubTasks.AsNoTracking()
                                         where subTask.TaskId == taskId
                                         select new SubTaskModel
                                         {
                                             SubTaskId = subTask.SubTaskId,
                                             SubTaskName = subTask.SubTaskName,
                                             TaskId = subTask.TaskId,
                                             Status = new StatusModel
                                             {
                                                 StatusId = subTask.Status.StatusId,
                                                 StatusType = subTask.Status.StatusType
                                             }
                                         }).ToListAsync();
            return searchedSubTask;
        }
    }
}
