using SOMSBlazorApp.Server.Repository;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Services
{
    public class WindowService : IWindowService
    {
        private readonly IWindowRepository _window;
        public WindowService(IWindowRepository window)
        {
            _window = window;
        }
        public async Task<Window> Add(Window window)
        {
            return await _window.CreateAsync(window);
        }

        public async Task<bool> Update(int id, Window window)
        {
            var data = await _window.GetByIdAsync(id);

            if (data != null)
            {
                data.WindowName = window.WindowName;
                data.QuantityOfElement = window.QuantityOfElement;
                await _window.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

        public async Task<bool> Delete(int id)
        {
            await _window.DeleteAsync(id);
            return true;
        }

        public async Task<List<Window>> GetAll()
        {
            return await _window.GetAllAsync();
        }

        public async Task<Window> Get(int id)
        {
            return await _window.GetByIdAsync(id);
        }
    }
}
