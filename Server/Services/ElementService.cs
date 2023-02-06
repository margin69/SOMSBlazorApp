using BlazorCRUDApp.Server.Models;
using BlazorCRUDApp.Server.Repository;
using SOMSBlazorApp.Server.Repository;
using SOMSBlazorApp.Server.Services;
using SOMSBlazorApp.Shared;

namespace BlazorCRUDApp.Server.Services
{
    public class ElementService : IElementService
    {
        private readonly IElementRepository _element;
        public ElementService(IElementRepository element)
        {
            _element = element;
        }
        public async Task<Element> Add(Element element)
        {
            return await _element.CreateAsync(element);
        }

        public async Task<bool> Update(int id, Element element) 
        {
            var data = await _element.GetByIdAsync(id);

            if (data != null)
            {  
                data.ElementType = element.ElementType;
                data.Width = element.Width;
                data.Height = element.Height;
                await _element.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

        public async Task<bool> Delete(int id)
        {
            await _element.DeleteAsync(id);
            return true;
        }

        public async Task<List<Element>> GetAll()
        {
            return await _element.GetAllAsync();
        }

        public async Task<Element> Get(int id)
        {
            return await _element.GetByIdAsync(id);
        }
    }
}
