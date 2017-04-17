using System;
using System.Linq;
using Utilities;

namespace Problems.Problems
{
    public class Problem0037: IProblem<int>
    {
        public int Solve()
        {
            var count = 0;
            var sum = 0;
            var n = 11;

            while (count < 11)
            {
                if (Utils.IsPrime(n))
                {
                    var add = true;

                    var chars = n.ToString().ToCharArray();
                    for (var i = 0; i < chars.Length; i++)
                    {
                        if (!(Utils.IsPrime(int.Parse(string.Join(string.Empty, chars.Skip(i))))
                            && Utils.IsPrime(int.Parse(string.Join(string.Empty, chars.Take(chars.Length - i))))))
                        {
                            add = false;
                            break;
                        }
                    }

                    if (add)
                    {
                        count++;
                        sum += n;
                    }
                }

                n++;
            }

            return sum;
        }
    }
}
