using System.Threading.Tasks;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Business.SubTask
{
    public class CreateSubTask : ICreateSubTask
    {
        private ICreateSubTaskRepo _createSubTaskRepo;
        public CreateSubTask(ICreateSubTaskRepo createSubTaskRepo)
        {
            _createSubTaskRepo = createSubTaskRepo;
        }
        public Task<int> Create(CreateSubTaskModel subTask)
        {
            return _createSubTaskRepo.Create(subTask);
        }
    }
}
