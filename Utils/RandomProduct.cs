using System.ComponentModel;

namespace cs_oppgave_01;

public class RandomProduct
{
    public static Random rnd = new Random();
    public static float RandomPrice(float min, float max)
    {
        double randomPrice = rnd.NextDouble() * (max - min) + min;
        return (float)randomPrice;
    }

    public static int RandomQuantity(int maxSize)
    {
        int min = 1;
        double randomInt = rnd.NextDouble() * (maxSize - min) + min;
        return (int)randomInt;
    }
    
}
