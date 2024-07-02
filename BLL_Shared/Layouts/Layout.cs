using BLL_Shared.Configurations;
using System.Diagnostics;

namespace BLL_Shared.Layouts;

[DebuggerDisplay($"{{{nameof(ToString)}(),nq}}")]
public class Layout : List<Layout>
{
    public Layout() { }
    public Layout(Orientation orientation, List<Layout> collection) : base(collection)
    {
        Orientation = orientation;
    }

    public LayoutType Type => Capacity == 0 ? LayoutType.Area : LayoutType.AreasHolder;
    public Orientation Orientation { get; set; }
    public Size Size { get; set; }

    AreaConfiguration Area { get; set; } = default!;

    private string ToString(Layout areas)
    {
        if (areas.Type == LayoutType.Area)
        {
            var s = areas.Size == Size.Full ? "□" : "■";
            return s;
        }
        else
        {
            string orientation = areas.Orientation switch
            {
                Orientation.Horizontal => "→",
                Orientation.Vertical => "↓",
                _ => throw new NotImplementedException(),
            };
            var s = areas.Size == Size.Full ? " " : "s";
            return $"{s}[ {orientation} {string.Join("", areas.Select(h => h.ToString()))} ]";
        }
    }
    public override string? ToString() => ToString(this);
}

