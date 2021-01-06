namespace Coding
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            foreach (var array in Array.GetPascalTriangle(10))
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
