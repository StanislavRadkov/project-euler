using Utilities;

namespace Problems
{
    public class Problem0026: IProblem<int>
    {
        public int Solve()
        {
            return LargestCycle(999);
        }

        public static int LargestCycle(int limit)
        {
            int maxLength = 0;
            int maxNumber = 2;
            int x = 0;

            for (var n = limit; n > 2; n--)
            {
                if (n % 2 == 0 || n % 5 == 0)
                {
                    continue;
                }

                x = ReciprocalCycle(n);
                if (x > maxLength)
                {
                    maxNumber = n;
                    maxLength = x;
                }
            }

            return maxNumber;
        }

        public static int ReciprocalCycle(int number)
        {
            var c = 1;
            var rem = 10 % number;

            while (rem != 1 && rem != 0)
            {
                rem = rem * 10 % number;
                c++;
            }

            return c;
        }
    }
}
