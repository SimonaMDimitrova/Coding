namespace Coding.Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MatchingBrackets
    {
        public static void GetAllExpressions(string input)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                var @char = input[i];

                if (@char == '(')
                {
                    stack.Push(i);
                }
                else if (@char == ')')
                {
                    var leftIndex = stack.Pop();
                    var expression = input.Substring(leftIndex, i - leftIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
