using System.Threading.Tasks;
using Tern.Interface.SubTask;

namespace Tern.Business.SubTask
{
    public class DeleteSubTask : IDeleteSubTask
    {
        private IDeleteSubTaskRepo _deleteSubTaskRepo;
        public DeleteSubTask(IDeleteSubTaskRepo deleteSubTaskRepo)
        {
            _deleteSubTaskRepo = deleteSubTaskRepo;
        }
        public async Task<int> Delete(int[] subTaskIds)
        {
            int rowAffected = 0;
             foreach(int id in subTaskIds)
            {
                rowAffected = await _deleteSubTaskRepo.Delete(id);
            }
            return rowAffected;
        }
    }
}
