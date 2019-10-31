using System;

namespace Challenge06
{
    class Program
    {
        static void grade(int num){
            if(num >= 90){
                Console.WriteLine("A");
            }else if(num >= 80 && num <= 89){
                Console.WriteLine("B");
            }else if(num >= 70 && num <= 79){
                Console.WriteLine("C");
            }else if(num >= 60 && num <= 69){
                Console.WriteLine("D");
            }else if(num <= 59){
                Console.WriteLine("E");
            }    
            
            
            
        }
        static void Main(string[] args)
        {
            grade(75);
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
        }
    }
}
