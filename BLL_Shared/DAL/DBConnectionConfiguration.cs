namespace BLL_Shared.DAL;

public record DBConnectionConfiguration
{
    public string ConnectionString { get; set; } = string.Empty;
}
