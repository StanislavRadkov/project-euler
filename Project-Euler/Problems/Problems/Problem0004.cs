using System;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0004 : IProblem<long>
    {
        public long Solve()
        {
            return findPalindromic();
        }

        public static int findPalindromic()
        {
            int palindromic = -1;

            for (var a = 999; a >= 100; a--)
            {
                for (var b = 999; b >= 100; b--)
                {
                    var c = a * b;

                    var s = c.ToString();
                    var arr = s.ToCharArray();
                    Array.Reverse(arr);

                    if (s == String.Join("", arr))
                    {
                        if (palindromic < c)
                        {
                            palindromic = c;
                        }
                    }
                }
            }

            return palindromic;
        }
    }
}
