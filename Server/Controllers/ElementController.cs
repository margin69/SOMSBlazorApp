using SOMSBlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using BlazorCRUDApp.Server.Services;
using SOMSBlazorApp.Server.Services;

namespace BlazorCRUDApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        private readonly IElementService _elementService;
        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpGet]
        public async Task<List<Element>> GetAll()
        {
            return await _elementService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Element> Get(int id)
        {
            return await _elementService.Get(id);
        }

        [HttpPost]
        public async Task<Element> AddElement([FromBody] Element element)
        {
           return await _elementService.Add(element);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteElement(int id)
        {
            await _elementService.Delete(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateElement(int id, [FromBody] Element Object)
        {
            await _elementService.Update(id, Object); return true;
        }
    }
}
