using System;
using System.Threading.Tasks;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Data.SubTaskRepository
{
    public class CreateSubTaskRepo : ICreateSubTaskRepo
    {
        private TernContext _ternContext;
        public CreateSubTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> Create(CreateSubTaskModel subTask)
        {
            Domain.SubTask newSubTask = new Domain.SubTask
            {
                SubTaskName = subTask.SubTaskName,
                TaskId = subTask.TaskId,
                StatusId = 1,
                CreatedDate = DateTime.Now
            };
            _ternContext.SubTasks.Add(newSubTask);
            await _ternContext.SaveChangesAsync();
            return newSubTask.SubTaskId;
        }
    }
}
