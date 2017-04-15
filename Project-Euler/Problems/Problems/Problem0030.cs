using System;
using Utilities;

namespace Problems
{
    public class Problem0030 : IProblem<int>
    {
        public int Solve()
        {
            var result = 0;

            for (var i = 2; i < 354294; i++)
            {
                var sumOfPowers = 0;
                var number = i;

                while (number > 0)
                {
                    int d = number % 10;
                    number /= 10;

                    sumOfPowers += (int)Math.Pow(d, 5);
                }

                if(sumOfPowers == i) {
                    result += i;
                }
            }

            return result;
        }
    }
}
