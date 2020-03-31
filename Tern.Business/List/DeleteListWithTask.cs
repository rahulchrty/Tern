using System.Threading.Tasks;
using Tern.Interface.List;

namespace Tern.Business.List
{
    public class DeleteListWithTask : IDeleteList
    {
        private IDeleteListWithTaskRepo _deleteListWithTaskRepo;
        public DeleteListWithTask(IDeleteListWithTaskRepo deleteListWithTaskRepo)
        {
            _deleteListWithTaskRepo = deleteListWithTaskRepo;
        }

        public bool isDeleteAllTasks {get {return true;} }

        public async Task<int> Delete(int listId)
        {
            return await _deleteListWithTaskRepo.DeleteListWithAllTask(listId);
        }
    }
}
