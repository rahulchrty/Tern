using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tern.Domain;
using Tern.Interface.SubTask;

namespace Tern.Data.SubTaskRepository
{
    public class UpdateSubTaskTitleRepo : IUpdateSubTaskTitleRepo
    {
        private TernContext _ternContext;
        public UpdateSubTaskTitleRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int UpdateTitle(int subTaskId, string title)
        {
            int rowAffected = 0;
            SubTask subTask = _ternContext.SubTasks.AsNoTracking().FirstOrDefault(x=>x.SubTaskId == subTaskId);
            if (subTask != null)
            {
                subTask.SubTaskName = title;
                _ternContext.SubTasks.Update(subTask);
                rowAffected = _ternContext.SaveChanges();
            }
            return rowAffected;
        }
    }
}
