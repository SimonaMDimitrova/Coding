﻿namespace Coding
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var numbers = Number
                .GetTheMersennePrimes();
            Console.WriteLine($"{string.Join(" x ", numbers)}");
        }
    }
}
