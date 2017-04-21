using System;
using System.Linq;
using Utilities;

namespace Problems.Problems
{
    public class Problem0040: IProblem<int>
    {
        public int Solve()
        {
            var fraction = String.Join(String.Empty, Enumerable.Range(1, 1000000)).ToCharArray().Select(c => (int)Char.GetNumericValue(c)).ToArray();
            
            return Enumerable.Range(0, 7).Select(i => fraction[(int)Math.Pow(10, i) - 1]).Aggregate(1, (a, b) => a * b);
        }
    }
}
