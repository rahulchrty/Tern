using Tern.Interface.Task;

namespace Tern.Business.Task
{
    public class TaskStatus : ITaskStatus
    {
        private ITaskStatusRepo _taskStatusRepo;
        public TaskStatus(ITaskStatusRepo taskStatusRepo)
        {
            _taskStatusRepo = taskStatusRepo;
        }
        public int UpdateStatus(int taskId, int statusId)
        {
            return _taskStatusRepo.UpdateStatus(taskId, statusId);
        }
    }
}
