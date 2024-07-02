//using BLL_Shared.Layouts;

//namespace BLL_Shared.Configurations;

//public class ServerConfiguration
//{
//    private readonly Dictionary<string, Layout> layoutSchemas;
//    public Dictionary<string, Layout> LayoutSchemas => layoutSchemas;

//    public ServerConfiguration()
//    {
//        layoutSchemas = GetLayoutSchemas();
//    }

//    private static Dictionary<string, Layout> GetLayoutSchemas()
//    {
//        var col1row1 = new Layout(Orientation.Horizontal, new(){
//                    new(),

//                });

//        var col1row2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    })

//                });

//        var col1row3 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    })

//                });

//        var col1row4 = new Layout(Orientation.Vertical, new()
//                {
//                    new(),
//                    new(),
//                    new(),
//                    new()
//                });

//        var col2row1row1 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(),
//                    new()
//                });

//        var col2row1row2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    })
//                });

//        var col2row1row3 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    })
//                });

//        var col2row1row4 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    })
//                });


//        var col2row2row1 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                    new()
//                });

//        var col2row2row2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row2row3 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row2row4 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row3row1 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new()
//                    }),
//                });
//        var col2row3row2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                });
//        var col2row3row3 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });
//        var col2row3row4 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row4row1 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new()
//                    }),
//                });


//        var col2row4row2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row4row3 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });

//        var col2row4row4 = new Layout(Orientation.Horizontal, new()
//                {
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }),
//                });

//        var col3row1row1row1 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(),
//                    new(),
//                    new()
//                });

//        var col2adv = new Layout(Orientation.Horizontal, new()
//                {
//                    new(){Size = Size.OneThird},
//                    new(){Size = Size.TwoThird}
//                });

//        var col2adv2 = new Layout(Orientation.Horizontal, new()
//                {
//                    new(){Size = Size.OneThird},
//                    new Layout(Orientation.Vertical, new()
//                    {
//                        new(),
//                        new(),
//                        new(),
//                        new()
//                    }){Size = Size.TwoThird}
//                });

//        return new([
//            new("test", col2adv2),
//            new("1 Column 1 Row", col1row1),

//            new("1 Column 2 Rows", col1row2),
//            new("1 Column 3 Rows", col1row3),
//            new("1 Column 4 Rows", col1row4),
//            new("2 Columns 1 Row 1 Row", col2row1row1),
//            new("2 Columns 1 Row 2 Rows", col2row1row2),
//            new("2 Columns 1 Row 3 Rows", col2row1row3),
//            new("2 Columns 1 Row 4 Rows", col2row1row4),
//            new("2 Columns 2 Rows 1 Row", col2row2row1),
//            new("2 Columns 2 Rows 2 Rows", col2row2row2),
//            new("2 Columns 2 Rows 3 Rows", col2row2row3),
//            new("2 Columns 2 Rows 4 Rows", col2row2row4),
//            new("2 Columns 3 Rows 1 Rows", col2row3row1),
//            new("2 Columns 3 Rows 2 Rows", col2row3row2),
//            new("2 Columns 3 Rows 3 Rows", col2row3row3),
//            new("2 Columns 3 Rows 4 Rows", col2row3row4),
//            new("2 Columns 4 Rows 1 Rows", col2row4row1),
//            new("2 Columns 4 Rows 2 Rows", col2row4row2),
//            new("2 Columns 4 Rows 3 Rows", col2row4row3),
//            new("2 Columns 4 Rows 4 Rows", col2row4row4),
//            //new("2 Columns 1:2 1 Row 1 Row", col2smallbigrow1row1),
//            //new("2 Columns 1:2 1 Row 2 Rows", col2smallbigrow1row2),
//            //new("2 Columns 1:2 1 Row 3 Rows", col2smallbigrow1row3),
//            //new("2 Columns 1:2 1 Row 4 Rows", col2smallbigrow1row4),
//            //new("2 Columns 1:2 2 Rows 1 Row", col2smallbigrow2row1),
//            //new("2 Columns 1:2 2 Rows 2 Rows", col2smallbigrow2row2),
//            //new("2 Columns 1:2 2 Rows 3 Rows", col2smallbigrow2row3),
//            //new("2 Columns 1:2 2 Rows 4 Rows", col2smallbigrow2row4),
//            //new("2 Columns 1:2 3 Rows 1 Rows", col2smallbigrow3row1),
//            //new("2 Columns 1:2 3 Rows 2 Rows", col2smallbigrow3row2),
//            //new("2 Columns 1:2 3 Rows 3 Rows", col2smallbigrow3row3),
//            //new("2 Columns 1:2 3 Rows 4 Rows", col2smallbigrow3row4),
//            //new("2 Columns 1:2 4 Rows 1 Rows", col2smallbigrow4row1),
//            //new("2 Columns 1:2 4 Rows 2 Rows", col2smallbigrow4row2),
//            //new("2 Columns 1:2 4 Rows 3 Rows", col2smallbigrow4row3),
//            //new("2 Columns 1:2 4 Rows 4 Rows", col2smallbigrow4row4),
//            //new("2 Columns 2:1 1 Row 1 Row", col2bigsmallrow1row1),
//            //new("2 Columns 2:1 1 Row 2 Rows", col2bigsmallrow1row2),
//            //new("2 Columns 2:1 1 Row 3 Rows", col2bigsmallrow1row3),
//            //new("2 Columns 2:1 1 Row 4 Rows", col2bigsmallrow1row4),
//            //new("2 Columns 2:1 2 Rows 1 Row", col2bigsmallrow2row1),
//            //new("2 Columns 2:1 2 Rows 2 Rows", col2bigsmallrow2row2),
//            //new("2 Columns 2:1 2 Rows 3 Rows", col2bigsmallrow2row3),
//            //new("2 Columns 2:1 2 Rows 4 Rows", col2bigsmallrow2row4),
//            //new("2 Columns 2:1 3 Rows 1 Rows", col2bigsmallrow3row1),
//            //new("2 Columns 2:1 3 Rows 2 Rows", col2bigsmallrow3row2),
//            //new("2 Columns 2:1 3 Rows 3 Rows", col2bigsmallrow3row3),
//            //new("2 Columns 2:1 3 Rows 4 Rows", col2bigsmallrow3row4),
//            //new("2 Columns 2:1 4 Rows 1 Rows", col2bigsmallrow4row1),
//            //new("2 Columns 2:1 4 Rows 2 Rows", col2bigsmallrow4row2),
//            //new("2 Columns 2:1 4 Rows 3 Rows", col2bigsmallrow4row3),
//            //new("2 Columns 2:1 4 Rows 4 Rows", col2bigsmallrow4row4),
//            //new("3 Columns 1 Row 1 Row 1 Row", col3row1row1row1),
//            //new("3 Columns 1 Row 1 Row 2 Rows", col3row1row1row2),
//            //new("3 Columns 1 Row 1 Row 3 Rows", col3row1row1row3),
//            //new("3 Columns 1 Row 1 Row 4 Rows", col3row1row1row4),
//            //new("3 Columns 1 Row 2 Rows 1 Row", col3row1row2row1),
//            //new("3 Columns 1 Row 2 Rows 2 Rows", col3row1row2row2),
//            //new("3 Columns 1 Row 2 Rows 3 Rows", col3row1row2row3),
//            //new("3 Columns 1 Row 2 Rows 4 Rows", col3row1row2row4),
//            //new("3 Columns 1 Row 3 Rows 1 Row", col3row1row3row1),
//            //new("3 Columns 1 Row 3 Rows 2 Rows", col3row1row3row2),
//            //new("3 Columns 1 Row 3 Rows 3 Rows", col3row1row3row3),
//            //new("3 Columns 1 Row 3 Rows 4 Rows", col3row1row3row4),
//            //new("3 Columns 1 Row 4 Rows 1 Row", col3row1row4row1),
//            //new("3 Columns 1 Row 4 Rows 2 Rows", col3row1row4row2),
//            //new("3 Columns 1 Row 4 Rows 3 Rows", col3row1row4row3),
//            //new("3 Columns 1 Row 4 Rows 4 Rows", col3row1row4row4),
//            //new("3 Columns 2 Rows 1 Row 1 Row", col3row2row1row1),
//            //new("3 Columns 2 Rows 1 Row 2 Rows", col3row2row1row2),
//            //new("3 Columns 2 Rows 1 Row 3 Rows", col3row2row1row3),
//            //new("3 Columns 2 Rows 1 Row 4 Rows", col3row2row1row4),
//            //new("3 Columns 2 Rows 2 Rows 1 Row", col3row2row2row1),
//            //new("3 Columns 2 Rows 2 Rows 2 Rows", col3row2row2row2),
//            //new("3 Columns 2 Rows 2 Rows 3 Rows", col3row2row2row3),
//            //new("3 Columns 2 Rows 2 Rows 4 Rows", col3row2row2row4),
//            //new("3 Columns 2 Rows 3 Rows 1 Row", col3row2row3row1),
//            //new("3 Columns 2 Rows 3 Rows 2 Rows", col3row2row3row2),
//            //new("3 Columns 2 Rows 3 Rows 3 Rows", col3row2row3row3),
//            //new("3 Columns 2 Rows 3 Rows 4 Rows", col3row2row3row4),
//            //new("3 Columns 2 Rows 4 Rows 1 Row", col3row2row4row1),
//            //new("3 Columns 2 Rows 4 Rows 2 Rows", col3row2row4row2),
//            //new("3 Columns 2 Rows 4 Rows 3 Rows", col3row2row4row3),
//            //new("3 Columns 2 Rows 4 Rows 4 Rows", col3row2row4row4),
//            //new("3 Columns 3 Rows 1 Row 1 Row", col3row3row1row1),
//            //new("3 Columns 3 Rows 1 Row 3 Rows", col3row3row1row3),
//            //new("3 Columns 3 Rows 1 Row 2 Rows", col3row3row1row2),
//            //new("3 Columns 3 Rows 1 Row 4 Rows", col3row3row1row4),
//            //new("3 Columns 3 Rows 2 Rows 1 Row", col3row3row2row1),
//            //new("3 Columns 3 Rows 2 Rows 2 Rows", col3row3row2row2),
//            //new("3 Columns 3 Rows 2 Rows 3 Rows", col3row3row2row3),
//            //new("3 Columns 3 Rows 2 Rows 4 Rows", col3row3row2row4),
//            //new("3 Columns 3 Rows 3 Rows 1 Row", col3row3row3row1),
//            //new("3 Columns 3 Rows 3 Rows 2 Rows", col3row3row3row2),
//            //new("3 Columns 3 Rows 3 Rows 3 Rows", col3row3row3row3),
//            //new("3 Columns 3 Rows 3 Rows 4 Rows", col3row3row3row4),
//            //new("3 Columns 3 Rows 4 Rows 1 Row", col3row3row4row1),
//            //new("3 Columns 3 Rows 4 Rows 2 Rows", col3row3row4row2),
//            //new("3 Columns 3 Rows 4 Rows 3 Rows", col3row3row4row3),
//            //new("3 Columns 3 Rows 4 Rows 4 Rows", col3row3row4row4),
//            //new("3 Columns 4 Rows 1 Row 1 Row", col3row4row1row1),
//            //new("3 Columns 4 Rows 1 Row 3 Rows", col3row4row1row3),
//            //new("3 Columns 4 Rows 1 Row 2 Rows", col3row4row1row2),
//            //new("3 Columns 4 Rows 1 Row 4 Rows", col3row4row1row4),
//            //new("3 Columns 4 Rows 2 Rows 1 Row", col3row4row2row1),
//            //new("3 Columns 4 Rows 2 Rows 2 Rows", col3row4row2row2),
//            //new("3 Columns 4 Rows 2 Rows 3 Rows", col3row4row2row3),
//            //new("3 Columns 4 Rows 2 Rows 4 Rows", col3row4row2row4),
//            //new("3 Columns 4 Rows 3 Rows 1 Row", col3row4row3row1),
//            //new("3 Columns 4 Rows 3 Rows 2 Rows", col3row4row3row2),
//            //new("3 Columns 4 Rows 3 Rows 3 Rows", col3row4row3row3),
//            //new("3 Columns 4 Rows 3 Rows 4 Rows", col3row4row3row4),
//            //new("3 Columns 4 Rows 4 Rows 1 Row", col3row4row4row1),
//            //new("3 Columns 4 Rows 4 Rows 2 Rows", col3row4row4row2),
//            //new("3 Columns 4 Rows 4 Rows 3 Rows", col3row4row4row3),
//            //new("3 Columns 4 Rows 4 Rows 4 Rows", col3row4row4row4),

//        ]);
//    }
//}
