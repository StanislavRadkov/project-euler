using System;
using Utilities;

namespace Problems
{
    public class Problem0012 : IProblem<int>
    {
        public int Solve()
        {
            var sum = 0;
            var i = 1;
            var go = true;

            do
            {
                sum += i;

                var divisorsCount = CalculateNumberOfDivisors(sum);

                if (divisorsCount >= 500)
                {
                    go = false;
                }

                i++;
            } while (go);

            return sum;
        }

        private int CalculateNumberOfDivisors(int number)
        {
            checked
            {
                var limit = Math.Sqrt(number);
                var divisors = 0;

                for (var i = 1; i <= limit; i++)
                {
                    if (number % i == 0)
                    {
                        divisors = divisors + 2; //For every exact divisor up to the square root, there is a corresponding divisor above the square root.
                    }
                }

                if (divisors > 0 && limit * limit == number)
                {
                    divisors--;
                }

                return divisors;
            }
        }
    }
}