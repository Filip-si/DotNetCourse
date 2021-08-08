using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCourse.Dtos.Item;
using DotNetCourse.Models;
using DotNetCourse.Services.ItemService;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCourse.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ItemController : ControllerBase
    {
        
        public ItemController(IItemService _itemService)
        {
            this.itemService = _itemService;
        }

        public IItemService itemService  { get; }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Item>>>> Add(AddItemDto newItem)
        {
            return Ok(await itemService.AddItem(newItem));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Item>>>> Get()
        {
            return Ok(await itemService.GetAllItems());
        }


    }
}