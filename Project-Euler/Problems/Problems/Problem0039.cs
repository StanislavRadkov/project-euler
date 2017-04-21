using Utilities;

namespace Problems.Problems
{
    public class Problem0039: IProblem<int>
    {
        public int Solve()
        {
            var max = 0;
            var maxP = 3;

            for (var p = 3; p < 1001; p++)
            {
                var count = 0;
                for (var a = 1; a < p + 1; a++)
                {
                    for (var b = 1; b < p - a; b++)
                    {
                        var c = p - a - b;
                        
                        if ((a * a + b * b == c * c))
                        {
                            count++;
                        }
                    }
                }                

                if (count > max)
                {
                    max = count;
                    maxP = p;
                }
            }

            return maxP;
        }
    }
}
