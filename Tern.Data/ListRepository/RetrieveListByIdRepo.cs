using Microsoft.EntityFrameworkCore;
using System.Linq;
using Tern.Interface.List;
using Tern.Model;

namespace Tern.Data.ListRepository
{
    public class RetrieveListByIdRepo : IRetrieveListByIdRepo
    {
        private TernContext _ternContext;
        public RetrieveListByIdRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public ListModel GetListById(int listId)
        {
            ListModel searchedList = (from list in _ternContext.Lists.AsNoTracking()
                                      where list.ListId == listId
                                      select new ListModel
                                      {
                                          ListId = list.ListId,
                                          ListName = list.ListName,
                                          Tasks = list.Tasks.Select(x => new TaskModel
                                          {
                                              TaskId = x.TaskId,
                                              TaskName = x.TaskName,
                                              Description = x.Description,
                                              Status = new StatusModel { StatusId = x.StatusId, StatusType = x.Status.StatusType }
                                          }).ToList()
                                      }).FirstOrDefault();
            return searchedList;
        }
    }
}
