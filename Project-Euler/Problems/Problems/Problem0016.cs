using System;
using System.Linq;
using System.Numerics;
using Utilities;

namespace Problems
{
    public class Problem0016 : IProblem<int>
    {
        public int Solve()
        {
            var number = BigInteger.Pow(new BigInteger(2), 1000);
            var sum = number.ToString().Aggregate(0, (n, c) => n + (int)Char.GetNumericValue(c));

            return sum;
        }
    }
}
