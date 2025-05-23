namespace cs_oppgave_01;

public class TextColors
{
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
        
        // product count :: if the difference is 10% or less 
        if (precentDiff <= 10)
        {
            return Color.RD;
        }

        // product count :: if stock is 5% or lower
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
        
        // product count :: if 'index' is less than 5% of 'store'
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
}