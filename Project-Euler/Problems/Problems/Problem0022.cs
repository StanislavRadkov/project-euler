using System.IO;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0022 : IProblem<int>
    {
        public int Solve()
        {
            var sum = 0;

            using (var file = new StreamReader("..\\..\\Files\\p022_names.txt"))
            {
                var names = file.ReadLine()
                               .Replace("\"", "")
                               .Split(',')
                               .OrderBy(x => x)
                               .ToArray();

                for (var i = 0; i < names.Count(); i++)
                {
                    sum += names[i].Sum(c => (int)c - 64) * (i + 1);
                }
            }

            return sum;
        }
    }
}
