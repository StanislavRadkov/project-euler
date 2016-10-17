using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Numerics;

namespace Problems
{
    public class Problem0029: IProblem<int>
    {
        public int Solve() 
        {
            var results = new List<BigInteger>(100 * 100);
            for (var a = 2; a <= 100; a++) 
            {
                for (var b = 2; b <= 100; b++) 
                {
                    results.Add(BigInteger.Pow(a, b));
                }
            }

            return results.Distinct().Count();
        }
    }
}
