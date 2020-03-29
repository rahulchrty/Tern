using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tern.Interface.List;
using Tern.Model;

namespace Tern.Data.ListRepository
{
    public class RetrieveListRepo : IRetrieveListRepo
    {
        private TernContext _ternContext;
        public RetrieveListRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<List<ListModel>> GetAllList()
        {
            List<ListModel> lists = await (from list in _ternContext.Lists
                                           select new ListModel
                                           {
                                               ListId = list.ListId,
                                               ListName = list.ListName
                                           }).ToListAsync();
            return lists;
        }
    }
}
