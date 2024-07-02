namespace BLL_Shared.Configurations.Charts;

public class BarChartConfiguration
{
    public bool IsRotated { get; set; }
}

public abstract class DxChartSeries
{
    public string Name { get; set; }
    public string Color { get; set; }
    public List<double> Data { get; set; } = new List<double>();
    public bool ShowMarkers { get; set; }
    public string MarkerType { get; set; } // Circle, Square, Triangle, etc.
    public int MarkerSize { get; set; }
    public string TooltipFormat { get; set; }
    public bool ShowLabels { get; set; }
    public string LabelFormat { get; set; }
    public string LabelFontColor { get; set; }
    public int LabelFontSize { get; set; }
}

public class DxChartBarSeries : DxChartSeries
{
    public string BarWidth { get; set; }
    public string BarSpacing { get; set; }
    public bool IsStacked { get; set; }
    public bool ShowValues { get; set; }
    public string ValuePosition { get; set; } // Inside, Outside
}

public class FormDataItem
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public int YearsWorked { get; set; }
    public string Position { get; set; }
}