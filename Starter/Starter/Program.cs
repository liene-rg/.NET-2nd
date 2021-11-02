using System;
using System.Collections;
using System.Collections.Generic;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text");
            string text = Console.ReadLine();

            /*
            int leftBracket = 0;
            int leftCurlyBrace = 0;
            int leftSquareBracket = 0;

            int rightBracket = 0;
            int rightCurlyBrace = 0;
            int rightSquareBracket = 0;

            foreach(char ch in text)
            {
                if (ch == '(')
                    leftBracket++;
                else if (ch == '{')
                    leftCurlyBrace++;
                else if (ch == '[')
                    leftSquareBracket++;
                else if (ch == ')')
                    rightBracket++;
                else if (ch == '}')
                    rightCurlyBrace++;
                else if (ch == ']')
                    rightSquareBracket++;
            }

            if (leftBracket == rightBracket &&
                leftCurlyBrace == rightCurlyBrace && leftSquareBracket == rightSquareBracket)
                Console.WriteLine("Matching Brackets");
            else
                Console.WriteLine("Brackets don't match");


         */


            if (BalancedPairs(text))
                Console.WriteLine("Match");
            else
                Console.WriteLine("No Match");


        }

       public static bool MatchingPair(char opening, char closing)
        {
            if (opening == '(' && closing == ')') return true;
            else if (opening == '{' && closing == '}') return true;
            else if (opening == '[' && closing == ']') return true;
            return false;
        }

        public static bool BalancedPairs(string txt)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '(' || txt[i] == '{' || txt[i] == '[')
                    stack.Push(txt[i]);
                else if (txt[i] == ')' || txt[i] == '}' || txt[i] == ']')
                {
                    if (stack.Count == 0  || !MatchingPair(stack.Peek(), txt[i])) 
                        return false;
                    else
                        stack.Pop();
                }
            }
            return stack.Count == 0 ? true : false; // empty stack means no unmatched brackets left in stack
        }






    }
}
