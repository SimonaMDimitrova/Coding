namespace Coding
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Number
    {
        public static bool IsNumberPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<int> GetAllPrimeNumbersByEratosthenesAlgorithm(int n)
        {
            var numbers = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                numbers.Add(i);
            }

            var move = 2;
            var index = 0;
            while (index <= n)
            {
                for (int i = index + move; i < numbers.Count; i += move)
                {
                    if (numbers.Count > i + move && numbers[i + move] == 0)
                    {
                        if (i > index)
                        {
                            numbers[i] = 0;
                        }

                        continue;
                    }
                    else
                    {
                        numbers[i] = 0;
                    }
                }

                move++;
                index++;
            }

            return numbers;
        }

        public static IEnumerable<int> DecompositeNumber(int number)
        {
            var numbers = new List<int>();

            var divider = 2;
            while (number > 1)
            {
                while (number % divider == 0)
                {
                    number /= divider;
                    numbers.Add(divider);
                }

                divider++;
            }

            return numbers;
        }

        public static int GCD(int a, int b)
        {
            return (0 == b) ? a : GCD(b, a % b);
        }

        public static int LCM(int[] numbers, int n)
        {
            if (n == 2)
            {
                return (numbers[0] * numbers[1]) / (GCD(numbers[0], numbers[1]));
            }

            var b = LCM(numbers, n - 1);

            var num = numbers[n - 1];

            return (num * b) / (GCD(num, b));
        }
    }
}
