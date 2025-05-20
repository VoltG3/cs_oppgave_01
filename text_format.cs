using System.Globalization;

namespace cs_oppgave_01;

public class TextFormat
{
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
    
    public static string ExtractProductName(string name)
    {
        switch (name)
        {
            case "HDD":
                return "Hard Disk Driver";
            case "SSD":
                return "Solid State Drive";
            case "RAM":
                return "Random Access Memory";
            case "CPU":
                return "Central Processing Unit";
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