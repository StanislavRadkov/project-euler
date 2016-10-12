using System;
using System.Collections.Generic;
using Utilities;

namespace Problems
{
    public class Problem0024 : IProblem<long>
    {
        private int[] _digits = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        private const int desiredPermuration = 1000000;

        public long Solve()
        {
            var used = new bool[_digits.Length];
            var result = new List<int>(_digits.Length);
            var counter = 0;
            string permutation = null;

            Permute(used, result, ref counter, ref permutation);

            return long.Parse(permutation);
        }

        public void Permute(bool[] used, List<int> result,  ref int counter, ref string permutation)
        {
            if (permutation != null)
            {
                return;
            }

            if (result.Count == _digits.Length)
            {
                counter++;

                if (counter == desiredPermuration)
                {
                    permutation = String.Join("", result);
                }

                return;
            }

            for (var i = 0; i < _digits.Length; i++)
            {
                if (used[i] == true)
                {
                    continue;
                }

                result.Add(_digits[i]);
                used[i] = true;

                Permute(used, result, ref counter, ref permutation);

                used[i] = false;
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
