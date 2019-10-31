using System;

namespace Challenge03
{
    class Program
    {
        static void CountString(string name){
            int pjg = name.Length;
            Console.WriteLine($"{name} have {pjg} characters");
        }
        static void Main(string[] args)
        {
            // Create new method called "CountString".
            // That method should accept a string and will
            // return length of characters input.
                CountString("Hello World!");
        }
    }
}
