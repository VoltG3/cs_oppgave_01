using System.Globalization;

namespace cs_oppgave_01;

public class TextFormat
{
    public static string QuantityBalance(string store, string index)
    {
        if (int.Parse(store) == int.Parse(index))
        {
            return Color.RD;
        }
        return Color.RS;
    }

    public static string FormatPrice(float price)
    {
        var culture = new CultureInfo("no-NO");
        culture.NumberFormat.NumberDecimalSeparator = ",";
        culture.NumberFormat.NumberGroupSeparator = ".";
        string formatted = price.ToString("#,0.00", culture);
        return formatted;
    }

    public static class Color
    {
        public const string RS = "\u001B[0m";    // Rest
        public const string GR = "\u001B[32m";   // Green
        public const string YL = "\u001B[33m";   // Yellow
        public const string BL = "\u001B[34m";   // Blue
        public const string PR = "\u001B[35m";   // Purple
        public const string CY = "\u001B[36m";   // Cyan
        public const string RD = "\u001B[31m";   // Red
    }
    public static string PaddingRight(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)160 }";
        }
        return line;
    }
    
    public static string PrintHorizontalLine(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)9552 }";
        }
        return line;
    }
    
    public static string ExtractProductPrefix(string name)
    {
        switch (name)
        {
            case "hdd":
                return "Hard Disk Driver";
            case "ssd":
                return "Solid State Drive";
            case "fdd":
                return "Floppy Disk Drive";
            case "ram":
                return "Random Access Memory";
            case "cpu":
                return "Central Processing Unit";
            case "gpu":
                return "Graphics Processing Unit";
            case "atx_e":
                return "Cabinet E-ATX";
            case "atx":
                return "Cabinet ATX";
            case "atx_m":
                return "Cabinet Micro-ATX";
            case "vga_m":
                return "CRT VGA Monochrome Display";
            case "svga":
                return "CRT SVGA Color Display";
            default:
                return name;
        }
    }
    
    public static void Space(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\n");
        }
    }
}