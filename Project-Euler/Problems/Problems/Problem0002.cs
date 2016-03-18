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
                long v1 = 1, v2 = 2;
                long sum = v2;

                do
                {
                    long v3 = v1 + v2;
                    v1 = v2;
                    v2 = v3;

                    if (v3%2 == 0)
                    {
                        sum += v3;
                    }

                } while (v2 <= 4000000);

                return sum;
            }
        }
    }
}
