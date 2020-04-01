using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tern.Interface.List;

namespace Tern.Data.ListRepository
{
    public class DeleteListWithTaskRepo : IDeleteListWithTaskRepo
    {
        private TernContext _ternContext;
        public DeleteListWithTaskRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> DeleteListWithAllTask(int listId)
        {
            int rowAffacted = 0;
            using (IDbContextTransaction transection = _ternContext.Database.BeginTransaction())
            {
                try
                {
                    List<Domain.Task> tasks = _ternContext.Tasks.Where(x => x.ListId == listId).ToList();
                    _ternContext.Tasks.RemoveRange(tasks);
                    rowAffacted += await _ternContext.SaveChangesAsync();

                    Domain.List list = new Domain.List { ListId = listId };
                    _ternContext.Lists.Attach(list);
                    _ternContext.Lists.Remove(list);
                    rowAffacted += await _ternContext.SaveChangesAsync();

                    await transection.CommitAsync();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return 0;
        }
    }
}
