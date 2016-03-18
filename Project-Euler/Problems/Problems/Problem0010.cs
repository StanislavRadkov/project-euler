using Utilities;

namespace Problems
{
    public class Problem0010 : IProblem<long>
    {
        public long Solve()
        {
            checked
            {
                var sum = 0L;

                for (var l = 2; l < 2000000; l++)
                {
                    if (Utils.IsPrime(l))
                    {
                        sum += l;
                    }
                }

                return sum;
            }
        }
    }
}
