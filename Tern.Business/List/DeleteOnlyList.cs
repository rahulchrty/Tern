using System.Threading.Tasks;
using Tern.Interface.List;

namespace Tern.Business.List
{
    public class DeleteOnlyList : IDeleteList
    {
        private IDeleteOnlyListRepo _deleteOnlyListRepo;
        public DeleteOnlyList(IDeleteOnlyListRepo deleteOnlyListRepo)
        {
            _deleteOnlyListRepo = deleteOnlyListRepo;
        }

        public bool isDeleteAllTasks { get { return false; } }

        public async Task<int> Delete(int listId)
        {
            return await _deleteOnlyListRepo.DeleteList(listId);
        }
    }
}
