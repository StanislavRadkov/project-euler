using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0001 : IProblem<int>
    {
        public int Solve()
        {
            checked
            {
                var result = Enumerable.Range(1, 999)
                                       .Where(x => x%3 == 0 || x%5 == 0)
                                       .Sum();

                return result;
            }
        }
    }
}
