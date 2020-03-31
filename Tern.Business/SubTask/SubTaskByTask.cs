using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Business.SubTask
{
    public class SubTaskByTask  : ISubTaskByTask
    {
        private ISubTaskByTaskRepo _subTaskByTaskRepo;
        public SubTaskByTask(ISubTaskByTaskRepo subTaskByTaskRepo)
        {
            _subTaskByTaskRepo = subTaskByTaskRepo;
        }
        public async Task<List<SubTaskModel>> GetSubTask(int taskId)
        {
            return await _subTaskByTaskRepo.GetSubTask(taskId);
        }
    }
}
