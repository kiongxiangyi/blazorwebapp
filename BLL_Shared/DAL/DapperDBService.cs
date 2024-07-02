using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BLL_Shared.DAL;

public class DapperDBService : IDBService
{
    private readonly DBConnectionConfiguration dBConnectionConfiguration;

    public DapperDBService(DBConnectionConfiguration dBConnectionConfiguration)
    {
        this.dBConnectionConfiguration = dBConnectionConfiguration;
    }

    public event Action<string> OnConnectionError = delegate { };

    public async Task<IEnumerable<T>> LoadAsync<T>(string target) where T : class, new()
    {
        using IDbConnection dbConnection = new SqlConnection(dBConnectionConfiguration.ConnectionString);

        try
        {
            dbConnection.Open();
        }
        catch (Exception ex)
        {
            OnConnectionError.Invoke(ex.Message);
            //throw new Exception("Failed to open database connection.", ex);
        }

        var sqlQuery = $"SELECT * FROM {target}";


        var loaded = await dbConnection.QueryAsync<T>(sqlQuery);
        return loaded;
    }

    public async IAsyncEnumerable<T> LoadByOneAsync<T>(string target) where T : class, new()
    {
        using (IDbConnection dbConnection = new SqlConnection(dBConnectionConfiguration.ConnectionString))
        {
            try
            {
                dbConnection.Open();
            }
            catch (Exception ex)
            {
                OnConnectionError.Invoke(ex.Message);
                //throw new Exception("Failed to open database connection.", ex);
            }

            var sqlQuery = $"SELECT * FROM {target}";

            foreach (var item in await dbConnection.QueryAsync<T>(sqlQuery))
                yield return item;
        }

    }
}
