using System.Linq;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Data.TaskRepository
{
    public class RetrieveTaskRepo : IRetrieveTaskRepo
    {
        private TernContext _ternContext;
        public RetrieveTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public TaskModel GetTaskById(int taskId)
        {
            TaskModel searchedTask = (from task in _ternContext.Tasks
                                      where task.TaskId == taskId
                                      select new TaskModel
                                      {
                                          TaskId = task.TaskId,
                                          Description = task.Description,
                                          Status = new StatusModel
                                          {
                                              StatusId = task.StatusId,
                                              StatusType = task.Status.StatusType
                                          },
                                          TaskName = task.TaskName,
                                          List = new ListModel
                                          {
                                              ListId = task.List.ListId,
                                              ListName = task.List.ListName
                                          }
                                      }).FirstOrDefault();
            return searchedTask;
        }
    }
}
