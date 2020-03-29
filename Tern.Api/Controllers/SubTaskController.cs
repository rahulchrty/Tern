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
        private IDeleteSubTask _deleteSubTask;
        public SubTaskController(ICreateSubTask createSubTask,
                                IRetrieveSubTask retrieveSubTask,
                                ISubTaskByTask subTaskByTask,
                                IDeleteSubTask deleteSubTask)
        {
            _createSubTask = createSubTask;
            _retrieveSubTask = retrieveSubTask;
            _subTaskByTask = subTaskByTask;
            _deleteSubTask = deleteSubTask;
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

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int[] subTaskIds)
        {
            await _deleteSubTask.Delete(subTaskIds);
            return StatusCode(204);
        }
    }
}