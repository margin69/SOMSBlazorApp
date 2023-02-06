using BlazorCRUDApp.Server.Services;
using Microsoft.AspNetCore.Mvc;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IService<Order> _windowService;
        public OrderController(IService<Order> windowService)
        {
            _windowService = windowService;
        }

        [HttpGet]
        public async Task<List<Order>> GetAll()
        {
            return await _windowService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            return await _windowService.Get(id);
        }

        [HttpPost]
        public async Task<Order> AddOrder([FromBody] Order window)
        {
            return await _windowService.Add(window);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteOrder(int id)
        {
            await _windowService.Delete(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateOrder(int id, [FromBody] Order Object)
        {
            await _windowService.Update(id, Object); return true;
        }
    }
}
