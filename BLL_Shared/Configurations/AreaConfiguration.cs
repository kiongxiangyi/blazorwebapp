namespace BLL_Shared.Configurations;

public class AreaConfiguration
{
    public string? Title { get; set; }
    public ViewType ViewType { get; set; } = default!;
    public DataConfiguration DataConfiguration { get; set; } = default!;
}
