using SOMSBlazorApp.Server.AppDbContext;
using SOMSBlazorApp.Server.Repository;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Repository
{
    public class ElementRepository : IElementRepository
    {
        ApplicationDbContext _dbContext;
        public ElementRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Element> CreateAsync(Element _object)
        {
            var obj = await _dbContext.Elements.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task UpdateAsync(Element _object)
        {
            _dbContext.Elements.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Element>> GetAllAsync()
        {
            return await _dbContext.Elements.ToListAsync();
        }

        public async Task<Element> GetByIdAsync(int Id)
        {
            return await _dbContext.Elements.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Elements.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}
