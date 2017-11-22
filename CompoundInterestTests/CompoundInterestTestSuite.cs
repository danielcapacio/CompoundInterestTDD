using System;
using Xunit;
using CompoundInterestLib;

namespace CompoundInterestTests
{
    public class CompoundInterestTestSuite
    {
        [Fact]
        public void givenPrincipal0ExpectAmount0()
        {
            double P = 0.0;
            CompoundInterest ci = new CompoundInterest();
            double actual = ci.getAmount(P, 1, 1, 1);
            double expected = 0;
            // System.Diagnostics.Debug.WriteLine(actual);
            // System.Diagnostics.Debug.WriteLine(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void givenNegativeTimeThrowException()
        {
            double n = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, n, 1)
            );
            string actual = ex.Message;
            string expected = "Time cannot be negative.";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void givenDivideYearsBy0ThrowException()
        {
            double n = 0.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, n, 1)
            );
            string actual = ex.Message;
            string expected = "Cannot divide by 0 years.";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void givenNegativeYearsThrowException()
        {
            double t = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, 1, t)
            );
            string actual = ex.Message;
            string expected = "Years cannot be negative.";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void givenSpecifiedParametersExpectAmount()
        {
            // A = 5000 (1 + 0.05 / 12) ^ (12(10)) = 8235.05
            double P = 5000;
            double r = 0.05;
            double n = 12.0;
            double t = 10.0;
            CompoundInterest ci = new CompoundInterest();
            double actual = Math.Round(ci.getAmount(P, r, n, t), 2); // round to 2 decimal places
            double expected = 8235.05;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void givenNegativePrincipalThrowException()
        {
            double P = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(P, 1, 1, 1)
            );
            string actual = ex.Message;
            string expected = "Principal cannot be negative.";
            Assert.Equal(expected, actual);
        }
    }
}
