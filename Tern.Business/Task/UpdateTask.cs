using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Business.Task
{
    public class UpdateTask : IUpdateTask
    {
        private IUpdateTaskRepo _updateTaskRepo;
        public UpdateTask(IUpdateTaskRepo updateTaskRepo)
        {
            _updateTaskRepo = updateTaskRepo;
        }
        public async Task<int> Update(TaskModel taskDetail)
        {
            return await _updateTaskRepo.Update(taskDetail);
        }
    }
}
