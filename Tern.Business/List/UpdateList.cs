using Tern.Interface.List;

namespace Tern.Business.List
{
    public class UpdateList : IUpdateList
    {
        private IUpdateListRepo _updateListRepo;
        public UpdateList(IUpdateListRepo updateListRepo)
        {
            _updateListRepo = updateListRepo;
        }
        public int Update(int listId, string listName)
        {
            return _updateListRepo.Update(listId, listName);
        }
    }
}
