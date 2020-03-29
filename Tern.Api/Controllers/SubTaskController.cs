using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Interface.SubTask;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/SubTask")]
    [ApiController]
    public class SubTaskController : ControllerBase
    {
        private ICreateSubTask _createSubTask;
        public SubTaskController(ICreateSubTask createSubTask)
        {
            _createSubTask = createSubTask;
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromForm] CreateSubTaskModel subTask)
        {
            int subTaskId = await _createSubTask.Create(subTask);
            return Created(new Uri($"{Request.Path}/{subTaskId}", UriKind.Relative), subTask); ;   
        }
    }
}