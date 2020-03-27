using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("ActiveTasks")]
        public ActionResult<List<TaskModel>> ActiveTasks()
        {
            List<TaskModel> tasks = new List<TaskModel>();
            tasks.Add(new TaskModel { TaskId = 1, TaskName = "my task", Description = "", Status = "active"});
            return tasks;
        }

        [HttpGet("Groups")]
        public ActionResult<List<ListModel>> Groups ()
        {
            List<ListModel> groups = new List<ListModel>();

            return groups;
        }
    }
}