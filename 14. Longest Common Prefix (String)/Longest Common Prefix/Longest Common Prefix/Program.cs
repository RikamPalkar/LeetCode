using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[]{ "flow", "flower", "flight" };
            Console.WriteLine(LongestCommonPrefix(input));
        }

        static string LongestCommonPrefix(string[] strs)
        {
            //validations
            if(strs.Length == 0)
            {
                return string.Empty;
            }

            //store the first string
            string firstString = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                
                while (strs[i].IndexOf(firstString) != 0)
                {
                    firstString = firstString[0..(firstString.Length - 1)];
                    if (string.IsNullOrEmpty(firstString)) return "";
                }
            }
            
            return firstString;
        }
    }
}
