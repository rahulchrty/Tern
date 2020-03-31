using System.Collections.Generic;
using Tern.Model;

namespace Tern.Interface.Status
{
    public interface IRetrieveStatus
    {
        List<StatusModel> GetStatus();
    }
}
