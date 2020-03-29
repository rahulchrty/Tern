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
        private IRetrieveSubTask _retrieveSubTask;
        private ISubTaskByTask _subTaskByTask;
        public SubTaskController(ICreateSubTask createSubTask,
                                IRetrieveSubTask retrieveSubTask,
                                ISubTaskByTask subTaskByTask)
        {
            _createSubTask = createSubTask;
            _retrieveSubTask = retrieveSubTask;
            _subTaskByTask = subTaskByTask;
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromForm] CreateSubTaskModel subTask)
        {
            int subTaskId = await _createSubTask.Create(subTask);
            return Created(new Uri($"{Request.Path}/{subTaskId}", UriKind.Relative), subTask); ;   
        }

        [HttpGet("{subTaskId}")]
        public ActionResult<SubTaskModel> GetSubTaskById ([FromRoute] int subTaskId)
        {
            return _retrieveSubTask.GetSubTask(subTaskId);
        }

        [HttpGet("{taskId}")]
        public async Task<ActionResult<List<SubTaskModel>>> GetSubTask([FromQuery] int taskId)
        {
            return await _subTaskByTask.GetSubTask(taskId);
        }
    }
}