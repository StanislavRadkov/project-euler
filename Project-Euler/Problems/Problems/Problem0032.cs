using System;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0032 : IProblem<int>
    {
        public int Solve()
        {
            var sum = 0;
            for (var i = 1; i < 10000; i++)
            {
                if (HasPandigitalProduct(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
            
        public static bool HasPandigitalProduct(int n)
        {
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0 && IsPandigital($"{n}{i}{n / i}"))
                    return true;
            }

            return false;
        }

        private static bool IsPandigital(string s)
        {
            return s.Length == 9 && String.Join(String.Empty, s.ToCharArray().OrderBy(x => x)).Equals("123456789");
        }
    }
}
