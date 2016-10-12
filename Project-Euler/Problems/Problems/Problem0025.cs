using System.Numerics;
using Utilities;

namespace Problems
{
    public class Problem0025 : IProblem<long>
    {
        public long Solve()
        {
            var a = new BigInteger(1);
            var b = new BigInteger(1);
            long counter = 2;

            while (b.ToString().Length < 1000)
            {
                var c = BigInteger.Add(a, b);
                a = b;
                b = c;
                counter++;
            }

            return counter;
        }
    }
}
