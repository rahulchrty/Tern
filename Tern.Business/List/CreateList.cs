using Tern.Interface.List;

namespace Tern.Business.List
{
    public class CreateList : ICreateList
    {
        private ICreateListRepo _createListRepo;
        public CreateList(ICreateListRepo createListRepo)
        {
            _createListRepo = createListRepo;
        }
        public int Create(string listName)
        {
            return _createListRepo.Create(listName);
        }
    }
}
