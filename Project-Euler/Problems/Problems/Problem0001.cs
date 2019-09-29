using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0001 : IProblem<int>
    {
        public int Solve()
        {
            checked
            {
                long n = 100;
                long sum = 0;

                sum += Sum(n, 3);
                sum += Sum(n, 5);
                sum -= Sum(n, 15);

                return (int)sum;
            }
        }

        private long Sum(long number, int divider)
        {
            if (divider == 0) return 0;

            long n = (number - 1) / divider;
            return divider * n * (n + 1) / 2;
        }
    }
}
