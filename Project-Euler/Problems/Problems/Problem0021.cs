using Utilities;

namespace Problems
{
    public class Problem0021 : IProblem<int>
    {
        public int Solve()
        {
            return sumAmicablePairs(10000);
        }

        private int sumDivisors(int number)
        {
            var s = 0;

            checked
            {
                for (var i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        s += i;
                    }
                }
            }
            return s;
        }

        private int sumAmicablePairs(int limit)
        {
            var sum = 0;

            checked
            {
                for (var i = 0; i <= limit; i++)
                {
                    var a = sumDivisors(i);

                    if (a > i && sumDivisors(a) == i) sum = sum + a + i;
                }
            }

            return sum;
        }
    }
}
