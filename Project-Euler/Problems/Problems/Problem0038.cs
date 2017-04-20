using System;
using System.Linq;
using Utilities;

namespace Problems.Problems
{
    public class Problem0038: IProblem<long>
    {
        public long Solve()
        {
            long result = 0;

            for (var n = 2; n <= 10; n++)
            {
                var range = Enumerable.Range(1, n);

                for (var i = 1; ; i++)
                {
                    var s = String.Join(String.Empty, range.Select(j => (j * i).ToString()));
                    if (s.Length > 9)
                    {
                        break;
                    }

                    var parsed = long.Parse(s);

                    var arr = s.ToCharArray();
                    Array.Sort(arr);

                    if (String.Join(String.Empty, arr) == "123456789")
                    {
                        result = Math.Max(result, parsed);
                    }
                }
            }

            return result;
        }
    }
}
