using Utilities;

namespace Problems
{
    public class Problem0028 : IProblem<int>
    {
        public int Solve()
        {
            checked
            {
                var sum = 1;
                var sideLength = 3;
                var sideCounter = 1;

                for (var i = 3; i <= 1002001;)
                {
                    sum += i;

                    sideCounter++;

                    if (sideCounter > 4)
                    {
                        sideCounter = 1;
                        sideLength += 2;
                    }

                    i += sideLength - 1;
                }

                return sum;
            }
        }
    }
}
