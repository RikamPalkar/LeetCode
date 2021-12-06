using System;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("([)]"));
        }

        static bool IsValid(string s)
        {
            Stack<char> paranthesisStack = new();
            foreach (char item in s)
            {
                switch (item)
                {
                    case '{':
                        paranthesisStack.Push('}');
                        break;
                    case '[':
                        paranthesisStack.Push(']');
                        break;
                    case '(':
                        paranthesisStack.Push(')');
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if (paranthesisStack.Count == 0)
                            return false;
                        if ( paranthesisStack.Pop() != item)
                            return false;
                        break;
                    default:
                        break;
                }
            }
            return paranthesisStack.Count == 0;
        }
    }
}
