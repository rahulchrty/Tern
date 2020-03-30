using Tern.Interface.List;
using Tern.Model;

namespace Tern.Business.List
{
    public class RetrieveListById : IRetrieveListById
    {
        private IRetrieveListByIdRepo _retrieveListByIdRepo;
        public RetrieveListById(IRetrieveListByIdRepo retrieveListByIdRepo)
        {
            _retrieveListByIdRepo = retrieveListByIdRepo;
        }
        public ListModel GetListById(int listId)
        {
            return _retrieveListByIdRepo.GetListById(listId);
        }
    }
}
