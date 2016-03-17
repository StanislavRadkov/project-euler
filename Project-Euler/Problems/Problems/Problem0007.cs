using Utilities;

namespace Problems
{
    public class Problem0007 : IProblem<int>
    {
        public int Solve()
        {
            var primeCounter = 0;
            var number = 1;

            while (primeCounter < 10001)
            {
                number++;

                if (Utils.IsPrime(number))
                {
                    primeCounter++;
                }
            }

            return number;
        }
    }
}
