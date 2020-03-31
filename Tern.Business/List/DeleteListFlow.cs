using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tern.Interface.List;
using System.Linq;

namespace Tern.Business.List
{
    public class DeleteListFlow : IDeleteListFlow
    {
        private IEnumerable<IDeleteList> _deleteList;
        public DeleteListFlow(IEnumerable<IDeleteList> deleteList)
        {
            _deleteList = deleteList;
        }
        public async Task<int> Delete(int listId, bool isDeleteAllTasks)
        {
            int rowAffacted = 0;
            IDeleteList deleteList = _deleteList.FirstOrDefault(x=>x.isDeleteAllTasks == isDeleteAllTasks);
            rowAffacted = await deleteList.Delete(listId);
            return rowAffacted;
        }
    }
}
