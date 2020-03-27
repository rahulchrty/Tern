using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Business.Task
{
    public class RetrieveTask : IRetrieveTask
    {
        private readonly IRetrieveTaskRepo _retrieveTaskRepo;
        public RetrieveTask(IRetrieveTaskRepo retrieveTaskRepo)
        {
            _retrieveTaskRepo = retrieveTaskRepo;
        }
        public TaskModel GetTaskById(int taskId)
        {
            return _retrieveTaskRepo.GetTaskById(taskId);  
        }
    }
}
