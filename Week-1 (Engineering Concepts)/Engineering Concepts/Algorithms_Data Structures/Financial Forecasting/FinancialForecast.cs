using System;

public class FinancialForecast
{
    public static double PredictFutureValue(double currentValue, double growthRate, int years)
    {
        // Base Case
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive Call
        return PredictFutureValue(currentValue, growthRate, years - 1)
               * (1 + growthRate);
    }
}

