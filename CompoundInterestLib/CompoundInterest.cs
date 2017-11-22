using System;

namespace CompoundInterestLib
{
    /**
        A = P*((1 + r/n)^(nt)), where:
        ---
        A = the future value of the investment/loan, including interest
        P = the principal investment amount(the initial deposit or loan amount)
        r = the annual interest rate(decimal)
        n = the number of times that interest is compounded per year
        t = the number of years the money is invested or borrowed for
    */
    public class CompoundInterest
    {
        public double getAmount(double P, double r, double n, double t)
        {
            // negative time throw exception
            if (n < 0)
            {
                throw new Exception("Time cannot be negative.");
            }

            // divide by zero exception when n = 0
            if (n == 0)
            {
                throw new Exception("Cannot divide by 0 time.");
            }

            // negative t throw exception
            if (t < 0)
            {
                throw new Exception("Years cannot be negative.");
            }

            // negative principal throw exception 
            if (P < 0)
            {
                throw new Exception("Principal cannot be negative.");
            }

            return (P * Math.Pow(1+(r/n), n*t));
        }
    }
}
