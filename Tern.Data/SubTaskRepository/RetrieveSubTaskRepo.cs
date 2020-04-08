using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Data.SubTaskRepository
{
    public class RetrieveSubTaskRepo : IRetrieveSubTaskRepo
    {
        private TernContext _ternContext;
        public RetrieveSubTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public SubTaskModel GetSubTask(int subTaskId)
        {
            SubTaskModel searchedSubTask = (from subTask in _ternContext.SubTasks.AsNoTracking()
                                            where subTask.SubTaskId == subTaskId
                                            select new SubTaskModel
                                            {
                                                SubTaskId = subTask.SubTaskId,
                                                SubTaskName = subTask.SubTaskName,
                                                Status = new StatusModel
                                                {
                                                    StatusId = subTask.Status.StatusId,
                                                    StatusType = subTask.Status.StatusType
                                                },
                                                TaskId = subTask.TaskId
                                            }).FirstOrDefault();
            return searchedSubTask;
        }
    }
}
