using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0)
        {
            return  0;
        }

        else if (speed < 5)
        {
            return 1;
        }

        else if(speed < 9)
        {
            return 0.9;
        }

        else if(speed == 9)
        {
            return 0.8;
        }

        else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double rate = SuccessRate(speed);
        double ratePerHour = 221 * speed * rate;

        return ratePerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double items = ProductionRatePerHour(speed);
        int itemsPerMinute = Convert.ToInt32(items)/60;

        return itemsPerMinute;
    }
}
