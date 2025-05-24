using System.Globalization;

namespace cs_oppgave_01;

public class TextFormat
{
    public static string Formula(int discountRange, string finalFlag)
    {
        if (finalFlag == "flow_empty")
            return "stock empty, no action";
        
        else if (finalFlag == "flow_quick" && discountRange == 3)
            return "perfect, discount 99%";
        
        else if (finalFlag == "flow_quick" && discountRange == 2)
            return "perfect, discount 33%";
        
        else if (finalFlag == "flow_quick" && discountRange == 1)
            return "perfect, discount 33%";
        
        else if (finalFlag == "flow_stack" && discountRange == 3)
            return "stack, discount 40%";
        
        else if (finalFlag == "flow_stack" && discountRange == 2)
            return "slow flow, discount 15%";
        
        else if (finalFlag == "flow_stack" && discountRange == 1)
            return "slow flow, discount 10%";
        
        else if (finalFlag == "flow_normal")
            return "normal flow, no action";
        
        else
        {
            return "X";
        }
    }
    
    public static string FormatPrice(float price)
    {
        var culture = new CultureInfo("no-NO");
        culture.NumberFormat.NumberDecimalSeparator = ",";
        culture.NumberFormat.NumberGroupSeparator = ".";
        string formatted = price.ToString("#,0.00", culture);
        return formatted;
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

    public static string PrintHorizontalSingleLine(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)9472 }";
        }
        return line;
    }
    
    public static string PrintHorizontalDoubleLine(int count)
    {
        var line = "";
        for (int i = 0; i < count; i++)
        {
            line += $"{ (char)9552 }";
        }
        return line;
    }
    
    public static string RankFlag(int num)
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
    
    public static string FullProductName(string name)
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