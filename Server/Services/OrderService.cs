using BlazorCRUDApp.Server.Repository;
using BlazorCRUDApp.Server.Services;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Services
{
    public class OrderService : IService<Order>
    {
        private readonly IRepository<Order> _order;
        public OrderService(IRepository<Order> order)
        {
            _order = order;
        }
        public async Task<Order> Add(Order order)
        {
            return await _order.CreateAsync(order);
        }

        public async Task<bool> Update(int id, Order order)
        {
            var data = await _order.GetByIdAsync(id);

            if (data != null)
            {
                data.OrderName = order.OrderName;
                data.State = order.State;
                await _order.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

        public async Task<bool> Delete(int id)
        {
            await _order.DeleteAsync(id);
            return true;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _order.GetAllAsync();
        }

        public async Task<Order> Get(int id)
        {
            return await _order.GetByIdAsync(id);
        }
    }
}
