namespace Tern.Interface.Task
{
    public interface ITaskStatus
    {
        int UpdateStatus(int taskId, int statusId);
    }
}
