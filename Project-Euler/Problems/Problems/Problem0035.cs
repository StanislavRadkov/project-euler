using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Problems
{
    public class Problem0035 : IProblem<int>
    {
        public int Solve()
        {
            return Enumerable.Range(1, 999999).Count(i => GetRotations(i).All(n => Utils.IsPrime(n)));
        }

        public List<int> GetRotations(int n)
        {
            if (n < 10)
            {
                return new List<int> { n };
            }

            var rotations = new List<int>();
            var chars = n.ToString().ToCharArray().ToList();

            Rotate(rotations, chars);

            return rotations;
        }

        private void Rotate(List<int> rotations, List<char> chars)
        {
            for (var i = 0; i < chars.Count; i++)
            {
                var first = chars[0];
                chars.RemoveAt(0);
                chars.Add(first);

                rotations.Add(int.Parse(String.Join(string.Empty, chars)));
            }
        }
    }
}
