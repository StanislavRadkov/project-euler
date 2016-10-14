using Utilities;

namespace Problems
{
    public class Problem0027: IProblem<int>
    {
        public int Solve()
        {
            checked
            {
                var maxA = -1;
                var maxB = -1;
                var maxPrimesCount = -1;

                for (var a = -999; a < 1000; a++)
                {
                    for (var b = -999; b <= 1000; b++)
                    {
                        var primesCount = 0;

                        for (var n = 0;; n++)
                        {
                            var value = n * n + a * n + b;

                            if (Utils.IsPrime(value))
                            {
                                primesCount++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (primesCount > maxPrimesCount)
                        {
                            maxA = a;
                            maxB = b;
                            maxPrimesCount = primesCount;
                        }
                    }
                }

                return maxA * maxB;
            }
        }
    }
}
