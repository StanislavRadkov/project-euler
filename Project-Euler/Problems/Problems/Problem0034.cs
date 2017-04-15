using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Problems
{
    public class Problem0034 : IProblem<int>
    {
        private static Dictionary<char, int> _factorials = new Dictionary<char, int>
        {
            { '0', 1 },
            { '1', 1 },
            { '2', 2 },
            { '3', 6 },
            { '4', 24 },
            { '5', 120 },
            { '6', 720 },
            { '7', 5040 },
            { '8', 40320 },
            { '9', 362880 }
        }; 

        public int Solve()
        {
            var sum = 0;
            for (var i = 3; i < 10000000; i++)
            {
                if (i == i.ToString().ToCharArray().Select(c => _factorials[c]).Sum())
                    sum += i;
            }
            return sum;
        }
    }
}
