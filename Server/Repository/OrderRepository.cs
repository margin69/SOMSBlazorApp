using BlazorCRUDApp.Server.AppDbContext;
using BlazorCRUDApp.Server.Repository;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Repository
{
    public class OrderRepository : IOrderRepository
    {
        ApplicationDbContext _dbContext;
        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Order> CreateAsync(Order _object)
        {
            var obj = await _dbContext.Orders.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task UpdateAsync(Order _object)
        {
            _dbContext.Orders.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int Id)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Orders.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}