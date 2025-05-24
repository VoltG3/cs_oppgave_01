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
    /*
      public const string RS = "\u001B[0m";     // Reset
          public const string BK = "\u001B[30m";    // Black
          public const string RD = "\u001B[31m";    // Red
          public const string GR = "\u001B[32m";    // Green
          public const string YL = "\u001B[33m";    // Yellow
          public const string BL = "\u001B[34m";    // Blue
          public const string PR = "\u001B[35m";    // Purple (Magenta)
          public const string CY = "\u001B[36m";    // Cyan
          public const string WH = "\u001B[37m";    // White
          
     public const string BK_B = "\u001B[90m";   // Bright Black (Gray)
       public const string RD_B = "\u001B[91m";   // Bright Red
       public const string GR_B = "\u001B[92m";   // Bright Green
       public const string YL_B = "\u001B[93m";   // Bright Yellow
       public const string BL_B = "\u001B[94m";   // Bright Blue
       public const string PR_B = "\u001B[95m";   // Bright Purple (Bright Magenta)
       public const string CY_B = "\u001B[96m";   // Bright Cyan
       public const string WH_B = "\u001B[97m";   // Bright White 
     */

    public static string MonthlyFlag(string flag)
    {
        //Console.WriteLine($"MonthlyFlag input: '{flag}'");
        switch (flag)
        {
            case "flow_quick":
                return Color.YL;
            case "flow_stack":
                return Color.RD;
            case "flow_normal":
                return Color.GR;
            case "flow_slow":
                return Color.PR;
            case "flow_empty":
                return Color.BL;
            default:
                return Color.RS;
        }
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
    
    public static string QuantityBalance(float prevIndex, float activeIndex)
    {
        var precentDiff = (prevIndex - activeIndex) * 100 / prevIndex;
        
        // product count :: if 10 or less than 10 left
        if (activeIndex <= 10)
        {
            return Color.YL;
        }
        
        // product count :: if equal
        if ((int)Math.Round(prevIndex) == (int)Math.Round(activeIndex))
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