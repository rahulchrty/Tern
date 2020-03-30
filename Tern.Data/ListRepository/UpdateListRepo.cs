using System.Linq;
using Tern.Domain;
using Tern.Interface.List;

namespace Tern.Data.ListRepository
{
    public class UpdateListRepo  : IUpdateListRepo
    {
        private TernContext _ternContext;
        public UpdateListRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public int Update(int listId, string listName)
        {
            int rowAffacted = 0;
            List list = _ternContext.Lists.FirstOrDefault(x=>x.ListId == listId);
            if (list != null)
            {
                list.ListName = listName;
                _ternContext.Lists.Update(list);
                rowAffacted = _ternContext.SaveChanges();
            }
            return rowAffacted;
        }
    }
}
