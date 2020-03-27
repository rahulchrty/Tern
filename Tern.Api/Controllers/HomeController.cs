using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IRetrieveActiveTask _retrieveActiveTask;
        public HomeController(IRetrieveActiveTask retrieveActiveTask)
        {
            _retrieveActiveTask = retrieveActiveTask;
        }

        [HttpGet("ActiveTasks")]
        public async Task<ActionResult<List<TaskModel>>> ActiveTasks()
        {
            return await _retrieveActiveTask.GetActiveTasks();
        }

        [HttpGet("Groups")]
        public ActionResult<List<ListModel>> Groups ()
        {
            List<ListModel> groups = new List<ListModel>();

            return groups;
        }
    }
}