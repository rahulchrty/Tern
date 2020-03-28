using Tern.Interface.Task;

namespace Tern.Business.Task
{
    public class MoveTask : IMoveTask
    {
        private IMoveTaskRepo _moveTaskRepo;
        public MoveTask(IMoveTaskRepo moveTaskRepo)
        {
            _moveTaskRepo = moveTaskRepo;
        }
        public int MoveToList(int taskId, int listId)
        {
            return _moveTaskRepo.MoveToList(taskId, listId);
        }
    }
}
