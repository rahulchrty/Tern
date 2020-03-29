using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Business.SubTask
{
    public class RetrieveSubTask : IRetrieveSubTask
    {
        private IRetrieveSubTaskRepo _retrieveSubTaskRepo;
        public RetrieveSubTask(IRetrieveSubTaskRepo retrieveSubTaskRepo)
        {
            _retrieveSubTaskRepo = retrieveSubTaskRepo;
        }
        public SubTaskModel GetSubTask(int subTaskId)
        {
            return _retrieveSubTaskRepo.GetSubTask(subTaskId);
        }
    }
}
