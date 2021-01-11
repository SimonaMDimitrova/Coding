namespace Coding
{
    using System;

    using Coding.Stack;

    public class StartUp
    {
        static void Main()
        {
            var expression = Expression.Evaluate("((1 + 2 + 2) * 3 - 100) / 2");
            Console.WriteLine(expression);
        }
    }
}
