using System.Globalization;

namespace cs_oppgave_01;

public class TextFormat
{
    public static string QuantityBalanceResult(string store, string index)
    {
        int storeVal = int.Parse(store);
        int indexVal = int.Parse(index);
        int indexValHalvYear = int.Parse(index) ;
        var precentDiff = (storeVal - indexValHalvYear) * 100 / storeVal;
        
        // product count :: if 10 or less than 10 left
        if (indexVal <= 10)
        {
            return Color.YL;
        }
        
        // product count :: if equal
        if (storeVal == indexVal)
        {
            return Color.RD;
        }
        
        // product count :: if difference is 10% or less 
        if (precentDiff <= 10)
        {
            return Color.RD;
        }

        // product count :: if stock is 5% or more lower
        if (precentDiff >= 5)
        {
            return Color.CY;
        }
        
        return Color.RS;
    }
    
    public static string QuantityBalance(string store, string index)
    {
        int storeVal = int.Parse(store);
        int indexVal = int.Parse(index);
        var precentDiff = (storeVal - indexVal) * 100 / storeVal;
        
        // product count :: if 10 or less than 10 left
        if (indexVal <= 10)
        {
            return Color.YL;
        }
        
        // product count :: if equal
        if (storeVal == indexVal)
        {
            return Color.RD;
        }
        
        // product count :: if 'index' is less 5% taht 'store'
        if (precentDiff >= 5)
        {
            return Color.CY;
        }
        
        if (precentDiff <= 5)
        {
            return Color.PR;
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

    public static string PrintSingleLine(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)9472 }";
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

    public static string ExtractProtectionRankFlag(int num)
    {
        switch (num)
        {
            case 1:
                return Color.RD;
            case 2:
                return Color.CY;
            case 3:
                return Color.YL;
            default:
                return Color.RS;
        }
    }
    public static string ExtractProtextionRank(int num)
    {
        switch (num)
        {
            case 1:
                return "HIG";
            case 2:
                return "MID";
            case 3:
                return "LOW";
            default:
                return "---";
        }
    }
    
    public static string ExtractProductPrefix(string name)
    {
        switch (name)
        {
            case "hdd_ide":
                return "Hard Disk Driver IDE 40mb";
            case "hdd_sata":
                return "Hard Disk Driver SATA 40Gb";
            case "ssd":
                return "Solid State Drive SSD 4Tb";
            case "fdd":
                return "Floppy Disk Drive 3,5\"";
            case "ram":
                return "Random Access Memory";
            case "cpu":
                return "Central Processing Unit";
            case "gpu_a":
                return "Graphics Processing Unit A";
            case "gpu_b":
                return "Graphics Processing Unit B";
            case "gpu_c":
                return "Graphics Processing Unit C";
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