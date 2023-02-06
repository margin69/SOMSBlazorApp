namespace BlazorCRUDApp.Server.Services
{
    public interface IService<T>
    {
        Task<T> Add(T _object);

        Task<bool> Update(int id, T _object);

        Task<bool> Delete(int id);

        Task<List<T>> GetAll();

        Task<T> Get(int id);

    }
}
