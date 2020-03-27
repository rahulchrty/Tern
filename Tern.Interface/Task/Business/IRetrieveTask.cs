using Tern.Model;

namespace Tern.Interface.Task
{
    public interface IRetrieveTask
    {
        TaskModel GetTaskById(int taskId);
    }
}
