using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0006 : IProblem<int>
    {
        public int Solve()
        {
            checked
            {
                var squareOfSum = 0;
                var sumOfSqaures = 0;

                sumOfSqaures = Enumerable.Range(1, 100).Aggregate((a, b) => a + (b * b));
                squareOfSum = Enumerable.Range(1, 100).Sum();

                squareOfSum = squareOfSum * squareOfSum;

                return squareOfSum - sumOfSqaures;
            }
        }
    }
}
