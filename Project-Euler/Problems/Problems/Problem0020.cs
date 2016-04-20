using System.Linq;
using System.Numerics;
using Utilities;

namespace Problems
{
    public class Problem0020 : IProblem<int>
    {
        public int Solve()
        {
            var result = Fact(new BigInteger(100));

            var sum = result.ToString().Select(c => (int) char.GetNumericValue(c)).Sum();

            return sum;
        }

        public BigInteger Fact(BigInteger n)
        {
            return n == 1 ? n : BigInteger.Multiply(n, Fact(BigInteger.Subtract(n, 1)));
        }
    }
}