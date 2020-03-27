using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/List")]
    [ApiController]
    public class ListController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create ([FromForm] string listName)
        {
            ListModel list = new ListModel();
            return Created(new Uri($"{Request.Path}/{list.ListId}", UriKind.Relative), list);
        }

        [HttpGet("{listId}")]
        public ActionResult<ListModel> Get ([FromRoute] int listId)
        {
            ListModel list = new ListModel { ListId = 1, ListName = "My list", Tasks = new List<TaskModel>()};
            return list;
        }

        [HttpPut("{listId}")]
        public IActionResult Update ([FromRoute] int listId, [FromForm] string listName)
        {
            return StatusCode(204);
        }

        [HttpDelete("{listId}")]
        public async Task<IActionResult> Delete ([FromRoute] int listId, [FromQuery] bool isDeleteAllTasks)
        {
            return StatusCode(204);
        }
    }
}