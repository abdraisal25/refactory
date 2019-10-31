using System;

namespace Challenge10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7
            Console.WriteLine(Sum(1,7));
        }

        static double Sum(double a, double b){
            return a + b;
        }

        static double Subtract(double a, double b){
            return a - b;
        }

        static double Multiply(double a, double b){
            return a * b;
        }

        static double Divide(double a, double b){
            return a / b;
        }
    }
}
