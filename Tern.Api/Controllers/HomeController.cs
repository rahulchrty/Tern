using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Interface.List;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IRetrieveActiveTask _retrieveActiveTask;
        private IRetrieveList _retrieveList;
        public HomeController(IRetrieveActiveTask retrieveActiveTask,
                            IRetrieveList retrieveList)
        {
            _retrieveActiveTask = retrieveActiveTask;
            _retrieveList = retrieveList;
        }

        [HttpGet("ActiveTasks")]
        public async Task<ActionResult<List<TaskModel>>> ActiveTasks()
        {
            return await _retrieveActiveTask.GetActiveTasks();
        }

        [HttpGet("Lists")]
        public async Task<ActionResult<List<ListModel>>> Lists()
        {
            return await _retrieveList.GetAllList();
        }
    }
}