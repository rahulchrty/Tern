using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tern.Interface.List;
using Tern.Model;

namespace Tern.Api.Controllers
{
    [Route("api/List")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private IRetrieveListById _retrieveListById;
        private ICreateList _createList;
        public ListController(IRetrieveListById retrieveListById,
                            ICreateList createList)
        {
            _retrieveListById = retrieveListById;
            _createList = createList;
        }
        [HttpPost]
        public IActionResult Create ([FromForm] string listName)
        {
            int listId = _createList.Create(listName);
            return Created(Url.RouteUrl(listId), listId);
        }

        [HttpGet("{listId}")]
        public ActionResult<ListModel> Get ([FromRoute] int listId)
        {
            return _retrieveListById.GetListById(listId); ;
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