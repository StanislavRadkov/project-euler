using Utilities;

namespace Problems
{
    public class Problem0009 : IProblem<long>
    {
        public long Solve()
        {
            checked
            {
                for (var a = 1; a < 1000; a++)
                {
                    for (var b = 1; b < 1000; b++)
                    {
                        for (var c = 1; c < 1000; c++)
                        {
                            if ((a * a + b * b) == c * c)
                            {
                                if ((a + b + c) == 1000)
                                {
                                    return a * b * c;
                                }
                            }
                        }
                    }
                }

                return -1;
            }
        }
    }
}
