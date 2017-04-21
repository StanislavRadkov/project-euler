using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Problems.Problems
{
    public class Problem0041: IProblem<int>
    {
        public int Solve()
        {
            
            var nonprimerLastDigits = new HashSet<int> { 0, 2, 4, 5, 6, 8 };

            var max = int.MinValue;

            for (var j = 9; j >= 1; j--)
            {
                var used = new bool[j];
                var result = new List<int>(j);

                Permute(Enumerable.Range(1, j).ToList(), used, result, (permutation) =>
                {
                    var x = permutation[permutation.Count - 1];
                    if (!nonprimerLastDigits.Contains(permutation[permutation.Count - 1]))
                    {
                        var n = int.Parse(String.Join(string.Empty, permutation));
                        if (Utils.IsPrime(n))
                        {
                            max = Math.Max(max, n);
                        }
                    }
                });

            }

            return max;
        }

        public void Permute(List<int> digits, bool[] used, List<int> result, Action<List<int>> callback)
        {
            if (result.Count == digits.Count)
            {
                callback(result);
            }

            for (var i = 0; i < digits.Count; i++)
            {
                if (used[i] == true)
                {
                    continue;
                }

                result.Add(digits[i]);
                used[i] = true;

                Permute(digits, used, result, callback);

                used[i] = false;
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
