using System;
using Utilities;

namespace Problems
{
    public class Problem0023 : IProblem<int>
    {
        private const int limit = 28123;

        private static readonly bool[] isAbundant = new bool[limit + 1];

        public int Solve()
        {
            // Compute look-up table
            for (var i = 1; i < isAbundant.Length; i++)
            {
                isAbundant[i] = IsAbundant(i);
            }

            var sum = 0;
            for (var i = 1; i <= limit; i++)
            {
                if (!IsSumOf2Abundants(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static bool IsSumOf2Abundants(int n)
        {
            for (var i = 0; i <= n; i++)
            {
                if (isAbundant[i] && isAbundant[n - i])
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsAbundant(int n)
        {
            var sum = 1; // Sum of factors less than n
            var end = (int) Math.Sqrt(n);
            for (var i = 2; i <= end; i++)
            {
                if (n % i == 0)
                {
                    sum += i + n / i;
                }
            }

            if (end * end == n)
            {
                sum -= end;
            }

            return sum > n;
        }
    }
}
