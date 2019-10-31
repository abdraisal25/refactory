using System;

namespace Challenge07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CelciusToFahrenheit(0)); // Output: 32
            Console.WriteLine(FahrenheitToCelcius(50)); // Output: 10
            Console.WriteLine(CelciusToKelvin(100)); // Output: 373.15
            Console.WriteLine(KelvinToCelcius(375)); // Output: 101.85
            Console.WriteLine(KelvinToFahrenheit(375)); // Output: 215.33
            Console.WriteLine(FahrenheitToKelvin(12)); // Output: 262.039
        }

        private static double CelciusToFahrenheit(double value)
        {
            return (value * 9 / 5)  + 32;
            // Console.WriteLine(hasil);
        }

        private static double FahrenheitToCelcius(double value)
        {
            return (value - 32) * 5 / 9;
            // Console.WriteLine(hasil);
        }

        private static double CelciusToKelvin(double value)
        {
            return value + 273.15;
            // Console.WriteLine(hasil);
        }

        private static double KelvinToCelcius(double value)
        {
            return value - 273.15;
            // Console.WriteLine(hasil);
        }

        private static double KelvinToFahrenheit(double value)
        {
            return (value - 273.15) * 9 / 5 + 32;
            // Console.WriteLine(hasil);
        }

        private static double FahrenheitToKelvin(double value)
        {
            return (value - 32) * 5 / 9 + 273.15;
            // Console.WriteLine(hasil);
        }
    }
}
