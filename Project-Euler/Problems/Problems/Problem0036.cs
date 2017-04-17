using System;
using Utilities;

namespace Problems
{
    public class Problem0036: IProblem<int>
    {
        public int Solve()
        {
            var sum = 0;
            for (var i = 0; i < 1000000; i++)
            {
                if (Utils.IsPalindrome(i.ToString()) && Utils.IsPalindrome(Convert.ToString(i, 2)))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
