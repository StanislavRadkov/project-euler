using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0002 : IProblem<long>
    {
        public long Solve()
        {
            checked
            {
                long n = 4000000;
                long v1 = 0, v2 = 1, v3 = 0;
                long sum = 0;

                while (v2 < n)
                {
                    v3 = v1 + v2;
                    v1 = v2;
                    v2 = v3;

                    if (v1 % 2 == 0)
                    {
                        sum += v1;
                    }

                }

                return sum;
            }
        }
    }
}
