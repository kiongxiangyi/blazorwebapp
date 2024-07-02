namespace BLL_Shared.DAL;

public interface IDBService
{
    event Action<string> OnConnectionError;

    Task<IEnumerable<T>> LoadAsync<T>(string target) where T : class, new();
    IAsyncEnumerable<T> LoadByOneAsync<T>(string target) where T : class, new();
}