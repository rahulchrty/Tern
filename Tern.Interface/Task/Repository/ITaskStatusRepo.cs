namespace Tern.Interface.Task
{
    public interface ITaskStatusRepo
    {
        int UpdateStatus(int taskId, int statusId);
    }
}
