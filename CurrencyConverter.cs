using System;

namespace CurrencyConversion
{
    class CurrencyConverter
    {
        // Convert amount from one currency to another
        public static double Convert(double amount, double rate)
        {
            return amount * rate;
        }

        // Convert using a fixed set of example currencies
        public static double ConvertUsdToEur(double usd)
        {
            double rate = 0.92; // example USD to EUR rate
            return Convert(usd, rate);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("=== Currency Conversion Test ===");

            double usdAmount = 100;
            double eurAmount = ConvertUsdToEur(usdAmount);

            Console.WriteLine($"{usdAmount} USD = {eurAmount} EUR");

            // Test generic conversion
            double inrAmount = 5000;
            double inrToUsdRate = 0.012; 
            double convertedUsd = Convert(inrAmount, inrToUsdRate);

            Console.WriteLine($"{inrAmount} INR = {convertedUsd} USD");
        }
    }
}
