using BLL_Shared.DAL;

namespace BLL_Shared.Configurations;

public class ClientConfiguration
{
    public int FontSizeModifier { get; set; }
    public DBConnectionConfiguration Connection { get; set; } = default!;
    public List<PageConfiguration> Pages { get; set; } = [];
    public TimeSpan PageShiftDelay { get; set; }
}
