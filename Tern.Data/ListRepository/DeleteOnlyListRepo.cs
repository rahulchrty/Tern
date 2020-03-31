using System;
using System.Threading.Tasks;
using Tern.Interface.List;

namespace Tern.Data.ListRepository
{
    public class DeleteOnlyListRepo : IDeleteOnlyListRepo
    {
        private TernContext _ternContext;
        public DeleteOnlyListRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public async Task<int> DeleteList(int listId)
        {
            int rowAffacted = 0;
            try
            {
                Domain.List list = new Domain.List { ListId = listId };
                _ternContext.Lists.Attach(list);
                _ternContext.Lists.Remove(list);
                rowAffacted = await _ternContext.SaveChangesAsync();
                return rowAffacted;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
