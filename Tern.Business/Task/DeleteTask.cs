using Tern.Interface.Task;

namespace Tern.Business.Task
{
    public class DeleteTask : IDeleteTask
    {
        private IDeleteTaskRepo _deleteTaskRepo;
        public DeleteTask(IDeleteTaskRepo deleteTaskRepo)
        {
            _deleteTaskRepo = deleteTaskRepo;
        }
        public int Delete(int taskId)
        {
            return _deleteTaskRepo.Delete(taskId);
        }
    }
}
