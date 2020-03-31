using System.Collections.Generic;
using System.Linq;
using Tern.Interface.Status;
using Tern.Model;

namespace Tern.Data.StatusRepository
{
    public class RetrieveStatusRepo : IRetrieveStatusRepo
    {
        private TernContext _ternContext;
        public RetrieveStatusRepo(TernContext ternContext)
        {
            _ternContext = ternContext;
        }
        public List<StatusModel> GetStatus()
        {
            List<StatusModel> allStatus = (from status in _ternContext.Status
                                     select new StatusModel
                                     {
                                         StatusId = status.StatusId,
                                         StatusType = status.StatusType
                                     }).ToList();
            return allStatus;
        }
    }
}
