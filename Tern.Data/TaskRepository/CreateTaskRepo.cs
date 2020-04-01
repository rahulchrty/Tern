using System;
using System.Threading.Tasks;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Data.TaskRepository
{
    public class CreateTaskRepo : ICreateTaskRepo
    {
        private TernContext _ternContext;
        public CreateTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> CreateNewTask(CreateTaskModel taskDetail)
        {
            var task = new Domain.Task {
                TaskName = taskDetail.TaskName,
                Description = taskDetail.Description,
                ListId = null,
                StatusId = 1,
                CreatedDate = DateTime.Now
            };
            _ternContext.Tasks.Add(task);
            await _ternContext.SaveChangesAsync();
            return task.TaskId;
        }
    }
}
