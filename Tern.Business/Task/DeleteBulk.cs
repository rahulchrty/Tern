using System.Threading.Tasks;
using Tern.Interface.Task;

namespace Tern.Business.Task
{
    public class DeleteBulk : IDeleteBulk
    {
        private IDeleteTaskRepo _deleteTaskRepo;
        public DeleteBulk(IDeleteTaskRepo deleteTaskRepo)
        {
            _deleteTaskRepo = deleteTaskRepo;
        }
        public async Task<int> Delete(int[] taskIds)
        {
            int totalRecordDeleted = 0;
            foreach (int id in taskIds)
            {
                totalRecordDeleted += await _deleteTaskRepo.DeleteAsync(id);
            }
            return totalRecordDeleted;
        }
    }
}
