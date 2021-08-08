using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCourse.Data;
using DotNetCourse.Dtos.Item;
using DotNetCourse.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace DotNetCourse.Services.ItemService
{
    public class ItemService : IItemService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ItemService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<GetItemDto>>> AddItem(AddItemDto newItem)
        {
            var serviceResponse = new ServiceResponse<List<GetItemDto>>();
            Item item = _mapper.Map<Item>(newItem);
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
            serviceResponse.Data =  await _context.Items.Select(i => _mapper.Map<GetItemDto>(i)).ToListAsync(); 
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetItemDto>>> GetAllItems()
        {
            var serviceResponse = new ServiceResponse<List<GetItemDto>>();
            var dbItems = await _context.Items.ToListAsync();
            serviceResponse.Data = dbItems.Select(i => _mapper.Map<GetItemDto>(i)).ToList();
            return serviceResponse;
        }

    }
}