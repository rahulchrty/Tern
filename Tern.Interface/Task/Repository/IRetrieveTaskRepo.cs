using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IRetrieveTaskRepo
    {
        TaskModel GetTaskById(int taskId);
    }
}
