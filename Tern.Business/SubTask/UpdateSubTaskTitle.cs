using Tern.Interface.SubTask;

namespace Tern.Business.SubTask
{
    public class UpdateSubTaskTitle : IUpdateSubTaskTitle
    {
        private IUpdateSubTaskTitleRepo _updateSubTaskTitleRepo;
        public UpdateSubTaskTitle(IUpdateSubTaskTitleRepo updateSubTaskTitleRepo)
        {
            _updateSubTaskTitleRepo = updateSubTaskTitleRepo;
        }
        public int UpdateTitle(int subTaskId, string title)
        {
           return _updateSubTaskTitleRepo.UpdateTitle(subTaskId, title);
        }
    }
}
