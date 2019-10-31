using System;

namespace Challenge18
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};

            Console.WriteLine(FindMax(numbers)); // Output: 330
            Console.WriteLine(FindMin(numbers)); // Output: -65
            Console.WriteLine(FindAverage(numbers)); // Output: 52.16
        }

        static int FindMax(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 1];
        }

        static int FindMin(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[0];
        }

        static double FindAverage(int[] numbers)
        {
            int jlh = 0;
            for(int i = 0; i < numbers.Length; i++){
                jlh += numbers[i];
            }
            double rata = jlh / numbers.Length;
            return rata;
        }
        }
    }
}
