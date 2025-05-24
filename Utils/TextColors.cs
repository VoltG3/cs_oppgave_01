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
        public const string WH_B = "\u001B[97m";   // Bright White
        public const string BK_B = "\u001B[90m";   // Bright Black (Gray)
        public const string RD_B = "\u001B[91m";   // Bright Red
        public const string GR_B = "\u001B[92m";   // Bright Green
        public const string YL_B = "\u001B[93m";   // Bright Yellow
        public const string BL_B = "\u001B[94m";   // Bright Blue
        public const string PR_B = "\u001B[95m";   // Bright Purple (Bright Magenta)
        public const string CY_B = "\u001B[96m";   // Bright Cyan
    }
    
    public static string Flag(string flag)
    {
        switch (flag)
        {
            case "flow_quick":
                return Color.YL_B;
            case "flow_stack":
                return Color.RD_B;
            case "flow_normal":
                return Color.GR_B;
            case "flow_slow":
                return Color.PR_B;
            case "flow_empty":
                return Color.BL_B;
            default:
                return Color.RS;
        }
    }
    
    public static string RankFlag(int num)
    {
        switch (num)
        {
            case 1:
                return Color.RD_B;
            case 2:
                return Color.CY_B;
            case 3:
                return Color.YL_B;
            default:
                return Color.RS;
        }
    }

    public static string OldPriceFlag(float oldPrice, float newPrice)
    {
        if (oldPrice > newPrice)
        {
            return Color.RD_B;
        }
        else
        {
            return Color.CY_B;
        }
    }
    
    public static string NewPriceFlag(float oldPrice, float newPrice)
    {
        if (oldPrice > newPrice)
        {
            return Color.GR;
        }
        else
        {
            return Color.CY_B;
        }
    }
}