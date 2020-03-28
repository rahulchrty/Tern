﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Data;
using Tern.Interface.Task;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/Task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private IRetrieveTask _retrieveTask;
        private ICreateTask _createTask;
        public TaskController(IRetrieveTask retrieveTask,
                            ICreateTask createTask)
        {
            _retrieveTask = retrieveTask;
            _createTask = createTask;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateTaskModel taskDetail)
        {
            try
            {
               int taskId = await _createTask.CreateNewTask(taskDetail);
                return Created(new Uri($"{Request.Path}/{taskId}", UriKind.Relative), taskDetail);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{taskId}")]
        public ActionResult<TaskModel> Get([FromRoute] int taskId)
        {
            TaskModel searchedTask = _retrieveTask.GetTaskById(taskId);
            return searchedTask;
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