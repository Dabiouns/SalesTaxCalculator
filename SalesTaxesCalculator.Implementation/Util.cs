using System;

namespace SalesTaxesCalculator.Generator
{
    public static class Util
    {
        public static double Round(float total)
        {
            return (Math.Ceiling(total * 20) / 20);
            //return (Math.Ceiling(total * 200) / 200);
        }

        internal static double Round(double total)
        {
           return (Math.Ceiling(total * 20) / 20);

         
            //return (Math.Ceiling(total * 200) / 200);
        }

        public static double RoundTo2Decimal(double total)
        {
            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }
    }
}
