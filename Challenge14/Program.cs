using System;

namespace Challenge14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            Console.WriteLine(IsPalindrome("ipsum")); // false
            Console.WriteLine(IsPalindrome("malam")); // true
            Console.WriteLine(IsPalindrome("tidur")); // false
            Console.WriteLine(IsPalindrome("kasur rusak")); // true
            Console.WriteLine(IsPalindrome("ibu ratna antar ubi")); // true
        }

        static bool IsPalindrome(string text)
        {
            string first = text.Substring(0, text.Length / 2);
            char[] data = text.ToCharArray();

            Array.Reverse(data);
            string temp = new string(data);
            string second = temp.Substring(0, temp.Length / 2);
            
            return first.Equals(second);
        }
    }
}
