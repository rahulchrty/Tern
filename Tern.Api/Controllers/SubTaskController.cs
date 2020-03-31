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
        private IUpdateSubTaskTitle _updateSubTaskTitle;
        public SubTaskController(ICreateSubTask createSubTask,
                                IRetrieveSubTask retrieveSubTask,
                                ISubTaskByTask subTaskByTask,
                                IDeleteSubTask deleteSubTask,
                                IUpdateSubTaskTitle updateSubTaskTitle)
        {
            _createSubTask = createSubTask;
            _retrieveSubTask = retrieveSubTask;
            _subTaskByTask = subTaskByTask;
            _deleteSubTask = deleteSubTask;
            _updateSubTaskTitle = updateSubTaskTitle;
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

        [HttpPut("Title/{subTaskId}")]
        public IActionResult UpdateSubTask([FromRoute] int subTaskId, [FromForm] string subTaskTitle)
        {
            _updateSubTaskTitle.UpdateTitle(subTaskId, subTaskTitle);
            return StatusCode(204);
        }

        [HttpPut("Status/{subTaskId}")]
        public async Task<IActionResult> UpdateStatus([FromRoute] int subTaskId, [FromForm] int status)
        {
            return StatusCode(204);
        }
    }
}