namespace cs_oppgave_01;

public class PrintOut
{
    public static void DataTable(List<string> data)
    {
        for (int i = 0; i < data.Count; i++)
        {
           Console.WriteLine(data[i]);
        }
    }
}