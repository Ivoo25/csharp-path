using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 10)
        {
            return 0.77;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1;
        }
        else
        {
            return 0;
        }
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }

    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        return (speed * 221 * SuccessRate(speed));
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        //return int
        return (int)Math.Floor(ProductionRatePerHour(speed) / 60);
    }
}
