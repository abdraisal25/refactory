using System;

namespace Challenge05
{
    class Program
    {
        static void IsOdd(int num){
            if(num % 2 == 0){
                Console.WriteLine("false");
            }else{
                Console.WriteLine("True");
            }
        }
        static void Main(string[] args)
        {
            IsOdd(4);
           // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
        }
    }
}
