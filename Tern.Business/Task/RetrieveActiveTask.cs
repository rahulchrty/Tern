using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Business.Task
{
    public class RetrieveActiveTask : IRetrieveActiveTask
    {
        private readonly IRetrieveActiveTaskRepo _retrieveActiveTaskRepo;
        public RetrieveActiveTask (IRetrieveActiveTaskRepo retrieveActiveTaskRepo)
        {
            _retrieveActiveTaskRepo = retrieveActiveTaskRepo;
        }
        public async Task<List<TaskModel>> GetActiveTasks()
        {
            return await _retrieveActiveTaskRepo.GetActiveTasks();
        }
    }
}
