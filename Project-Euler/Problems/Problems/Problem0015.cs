using System.Numerics;
using Utilities;

namespace Problems
{
    public class Problem0015 : IProblem<BigInteger>
    {
        public BigInteger Solve()
        {
            var a = 20;
            var b = 20;

            //http://www.mathwords.com/c/combination_formula.htm
            var num = Factorial(a + b);
            var den = BigInteger.Multiply(Factorial(a), Factorial(b));
            var k = BigInteger.Divide(num, den);

            return k;
        }

        public BigInteger Factorial(int num)
        {
            return Factorial(new BigInteger(num));
        }

        public BigInteger Factorial(BigInteger num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return BigInteger.Multiply(num, Factorial(BigInteger.Subtract(num, 1)));

            }

        }
    }
}