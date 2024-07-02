using BLL_Shared.Layouts;

namespace BLL_Shared.Configurations;

public class ServerConfiguration
{
    private readonly List<(string name, Layout layout)> layoutSchemas;
    public List<(string name, Layout layout)> LayoutSchemas => layoutSchemas;

    //private Dictionary<>

    public ServerConfiguration()
    {
        layoutSchemas = GetLayoutSchemas();
    }

    private static List<(string name, Layout layout)> GetLayoutSchemas()
    {
        /* HorizontalHolder(divideBy: 3) means that div will be created with 3 div-Areas placed horizontally (in row)(or with 3 columns) */
        var layoutsCollection = new List<Layout>(
            [
            Single(),
            HorizontalHolder(VerticalHolder(divideBy: 2), VerticalHolder(Size.OneThird, divideBy: 2)),
            HorizontalHolder(divideBy: 2),
            HorizontalHolder(divideBy: 3),
            HorizontalHolder(divideBy: 4),
            VerticalHolder(divideBy: 2),
            VerticalHolder(divideBy: 3),
            VerticalHolder(divideBy: 4),
            HorizontalHolder(Single(Size.OneThird), Single()),
            VerticalHolder(Single(Size.OneThird), Single(Size.Quarter), Single()),
            HorizontalHolder(Single(), Single(Size.OneThird)),
            HorizontalHolder(Single(), VerticalHolder(Size.OneThird, divideBy: 2)),
            VerticalHolder(Single(), HorizontalHolder(Size.OneThird, divideBy: 2)),
            HorizontalHolder(Single(), VerticalHolder(Size.OneThird, Single(), Single(Size.OneThird))),
            VerticalHolder(Single(), HorizontalHolder(Size.OneThird, Single(), Single(Size.OneThird))),
            ]);

        return new(layoutsCollection.Select(l => (l.ToString()!, l)));
    }
    #region static helpers
    private static Layout HorizontalHolder(Size size, params Layout[] layouts) => AreasHolder(Orientation.Horizontal, size, layouts);
    private static Layout VerticalHolder(Size size, params Layout[] layouts) => AreasHolder(Orientation.Vertical, size, layouts);
    private static Layout AreasHolder(Orientation orientation, Size size, params Layout[] layouts) => layouts.Length <= 1
            ? throw new Exception("Should be more than 1")
            : new Layout(orientation, layouts.ToList()) { Size = size };
    private static Layout HorizontalHolder(int divideBy) => AreasHolder(Orientation.Horizontal, divideBy);
    private static Layout VerticalHolder(int divideBy) => AreasHolder(Orientation.Vertical, divideBy);
    private static Layout HorizontalHolder(Size size, int divideBy) => AreasHolder(Orientation.Horizontal, size, divideBy);
    private static Layout VerticalHolder(Size size, int divideBy) => AreasHolder(Orientation.Vertical, size, divideBy);
    private static Layout HorizontalHolder(params Layout[] layouts) => AreasHolder(Orientation.Horizontal, layouts);
    private static Layout VerticalHolder(params Layout[] layouts) => AreasHolder(Orientation.Vertical, layouts);
    private static Layout AreasHolder(Orientation orientation, params Layout[] layouts) => layouts.Length <= 1 ? throw new Exception("Should be more than 1") : new Layout(orientation, layouts.ToList());
    private static Layout AreasHolder(Orientation orientation, int divideBy) => divideBy <= 1 ? throw new Exception("Should be more than 1") : new Layout(orientation, Single(divideBy));
    private static Layout AreasHolder(Orientation orientation, Size size, int divideBy) => divideBy <= 1 ? throw new Exception("Should be more than 1") : new Layout(orientation, Single(divideBy)) { Size = size };
    private static List<Layout> Single(int count) => Enumerable.Range(1, count).Select(i => new Layout()).ToList();
    private static Layout Single() => new();
    private static Layout Single(Size size) => new() { Size = size };
    #endregion
}
