using System.Collections.Generic;
using Tern.Interface.Status;
using Tern.Model;

namespace Tern.Business.Status
{
    public class RetrieveStatus : IRetrieveStatus
    {
        private readonly IRetrieveStatusRepo _retrieveStatusRepo;
        public RetrieveStatus(IRetrieveStatusRepo retrieveStatusRepo)
        {
            _retrieveStatusRepo = retrieveStatusRepo;
        }
        public List<StatusModel> GetStatus()
        {
            return _retrieveStatusRepo.GetStatus();
        }
    }
}
