using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface IRetrieveSubTaskRepo
    {
        SubTaskModel GetSubTask(int subTaskId);
    }
}
