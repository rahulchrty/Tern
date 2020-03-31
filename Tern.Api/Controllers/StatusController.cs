using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tern.Interface.Status;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IRetrieveStatus _retrieveStatus;
        public StatusController(IRetrieveStatus retrieveStatus)
        {
            _retrieveStatus = retrieveStatus;
        }
        [HttpGet]
        public ActionResult<List<StatusModel>> GetStatus()
        {
            return _retrieveStatus.GetStatus();
        }
    }
}