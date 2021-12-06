using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res = IsPalindrome(121);
            Console.WriteLine(res);
        }

        static  bool IsPalindrome(int x)
        {
            int remainder = 0;
            int sum = 0;
            int initialNum = x;
            while (x > 0)
            {
                remainder = x % 10;
                x /= 10;
                sum = sum * 10 + remainder;
            }
            if (sum == initialNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
