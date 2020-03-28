using System.Collections.Generic;
using System.Threading.Tasks;
using Tern.Model;

namespace Tern.Interface.List
{
    public interface IRetrieveListRepo
    {
        Task<List<ListModel>> GetAllList();
    }
}
