namespace cs_oppgave_01;

public class TextFormat
{
    private string ExtractName(string name)
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