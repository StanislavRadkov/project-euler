using System;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0005 : IProblem<int>
    {
        public int Solve()
        {
            var number = -1;

            for (number = 1; number < 999999999; number++)
            {
                var remainder = 0;

                for (var divider = 20; divider >= 10; divider--)
                {
                    remainder = number % divider;

                    if (remainder != 0)
                        break;
                }

                if (remainder == 0)
                    break;
            }

            return number;
        }
    }
}
