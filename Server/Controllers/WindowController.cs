using BlazorCRUDApp.Server.Services;
using Microsoft.AspNetCore.Mvc;
using SOMSBlazorApp.Server.Services;
using SOMSBlazorApp.Shared;

namespace SOMSBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowController : ControllerBase
    {
        private readonly IWindowService _windowService;
        public WindowController(IWindowService windowService)
        {
            _windowService = windowService;
        }

        [HttpGet]
        public async Task<List<Window>> GetAll()
        {
            return await _windowService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Window> Get(int id)
        {
            return await _windowService.Get(id);
        }

        [HttpPost]
        public async Task<Window> AddWindow([FromBody] Window window)
        {
            return await _windowService.Add(window);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteWindow(int id)
        {
            await _windowService.Delete(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateWindow(int id, [FromBody] Window Object)
        {
            await _windowService.Update(id, Object); return true;
        }
    }
}
