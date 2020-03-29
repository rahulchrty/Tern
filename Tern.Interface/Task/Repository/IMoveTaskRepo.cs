namespace Tern.Interface.Task
{
    public interface IMoveTaskRepo
    {
        int MoveToList(int taskId, int listId);
    }
}
