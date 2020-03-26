using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromForm] CreateTaskModel taskDetail)
        {
            try
            {
                TaskModel task = new TaskModel { TaskId = 1, TaskName = "my task", Description = "", Status = "active" };
                return Created(new Uri($"{Request.Path}/{task.TaskId}", UriKind.Relative), task);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{taskId}")]
        public ActionResult<TaskModel> Get([FromRoute] int taskId)
        {
            return new TaskModel { TaskId = 1, TaskName = "my task", Description = "", Status = "active" };
        }

        [HttpPut("{taskId}")]
        public IActionResult Update([FromRoute] int taskId, [FromForm] CreateTaskModel taskDetail)
        {
            return StatusCode(204);
        }

        [HttpDelete("{taskId}")]
        public IActionResult Delete([FromRoute] int taskId)
        {
            return StatusCode(204);
        }

        [HttpPost("DeleteMany")]
        public async Task<IActionResult> AsyncBulkDelete([FromBody] int[] taskIds)
        {
            return StatusCode(204);
        }
    }
}