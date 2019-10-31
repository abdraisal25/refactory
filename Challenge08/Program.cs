using System;

namespace Challenge08
{
    class Program
    {
        static bool IsLeapYear(int year){
            if(year % 4 == 0){
                return true;
            }else{
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsLeapYear(num));
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
        }
    }
}
