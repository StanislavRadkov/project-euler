using System;
using System.Linq;
using Utilities;

namespace Problems
{
    public class Problem0006 : IProblem<int>
    {
        public int Solve()
        {
            var squareOfSum = 0;
            var sumOfSqaures = 0;

            for (var i = 1; i <= 100; i++)
            {
                sumOfSqaures += i * i;
            }

            sumOfSqaures = Enumerable.Range(1, 100).Aggregate((a, b) => a + (b*b));
            squareOfSum = Enumerable.Range(1, 100).Sum();

            squareOfSum = squareOfSum * squareOfSum;

            return squareOfSum - sumOfSqaures;
        }
    }
}
