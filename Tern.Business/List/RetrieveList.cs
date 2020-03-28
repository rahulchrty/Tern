using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Interface.List;
using Tern.Model;

namespace Tern.Business.List
{
    public class RetrieveList : IRetrieveList
    {
        private readonly IRetrieveListRepo _retrieveListRepo;
        public RetrieveList(IRetrieveListRepo retrieveListRepo)
        {
            _retrieveListRepo = retrieveListRepo;
        }
        public async Task<List<ListModel>> GetAllList()
        {
            return await _retrieveListRepo.GetAllList();
        }
    }
}
