using System;
using System.Collections.Generic;

namespace SubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LengthOfLongestSubString("abcabcbb");
            Console.WriteLine(res);
        }


        static int LengthOfLongestSubString(string s)
        {
            //2 pointers
            int i = 0 , j = 0, lengthOfString = 0;
            HashSet<char> characters = new();
            while (j < s.Length)
            {
                //Checking if set contains the character or not
                if (!characters.Contains(s[j]))
                {
                    //Set does not contain the character so adding it
                    characters.Add(s[j]);

                    //Moving on with next character
                    j++;

                    // We are only doing to calculate the count in this if
                    // that way we can keep the track of last successful substring before we start removing
                    // abca = abc = 3
                    // next 'a' will remove the first a's entry from set, so the size will be 2, But taking max value from the last value
                    lengthOfString = Math.Max(characters.Count, lengthOfString);
                }
                //find duplicate
                else
                {
                    characters.Remove(s[i]);
                    i++;
                }
            }
            return lengthOfString;
        }
    }
}
