using Microsoft.AspNetCore.Mvc;
using SOMSBlazorApp.Server.Services;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<List<Order>> GetAll()
        {
            return await _orderService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            return await _orderService.Get(id);
        }

        [HttpPost]
        public async Task<Order> AddOrder([FromBody] Order order)
        {
            return await _orderService.Add(order);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteOrder(int id)
        {
            await _orderService.Delete(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateOrder(int id, [FromBody] Order Object)
        {
            await _orderService.Update(id, Object); return true;
        }
    }
}
