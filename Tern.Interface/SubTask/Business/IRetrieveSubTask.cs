using Tern.Model;

namespace Tern.Interface.SubTask
{
    public interface IRetrieveSubTask
    {
        SubTaskModel GetSubTask(int subTaskId);
    }
}
