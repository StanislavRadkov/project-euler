using System;
using Utilities;

namespace Problems
{
    public class Problem0031 : IProblem<int>
    {
        private static readonly int[] _coins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
        private static readonly int _val = 200;

        public int Solve()
        {
            var sums = 0;

            Sum(0, ref sums, 0);

            return sums;
        }

        private static void Sum(int sum, ref int sums, int pos)
        {
            checked
            {
                if (sum == _val)
                {
                    sums++;
                    return;
                }

                for (var i = pos; i < _coins.Length; i++)
                {
                    if (sum + _coins[i] <= _val)
                    {
                        Sum(sum + _coins[i], ref sums, i);
                    }
                }
            }
        }
    }
}
