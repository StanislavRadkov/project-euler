using System;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0003 : IProblem<long>
    {
        public long Solve()
        {
            checked
            {
                long number = 600851475143;

                for (var i = 2; i < number; i++)
                {
                    if (number % i == 0 && Utils.IsPrime(i))
                    {
                        number = number / i;
                    }
                }

                return number;
            }
        }
    }
}
