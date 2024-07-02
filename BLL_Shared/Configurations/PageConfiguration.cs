using BLL_Shared.Layouts;

namespace BLL_Shared.Configurations;

public class PageConfiguration
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public Layout Layout { get; set; } = [];
}
