using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Business.Task
{
    public class CreateTask : ICreateTask
    {
        private readonly ICreateTaskRepo _createTaskRepo;
        public CreateTask(ICreateTaskRepo createTaskRepo)
        {
            _createTaskRepo = createTaskRepo;
        }
        public async Task<int> CreateNewTask(CreateTaskModel taskDetail)
        {
            return await _createTaskRepo.CreateNewTask(taskDetail);
        }
    }
}
