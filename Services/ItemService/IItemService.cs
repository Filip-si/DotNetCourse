using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCourse.Dtos.Item;
using DotNetCourse.Models;

namespace DotNetCourse.Services.ItemService
{
    public interface IItemService
    {
         Task<ServiceResponse<List<GetItemDto>>> GetAllItems();

         Task<ServiceResponse<List<GetItemDto>>> AddItem(AddItemDto newItem);
         
    }
}