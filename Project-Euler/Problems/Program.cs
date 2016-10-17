using System;

namespace Problems
{
    class Program
    {
        private static void Main(string[] args)
        {
            var start = DateTime.Now;

            var problem = new Problem0028();
            Console.WriteLine(problem.Solve());

            var end = DateTime.Now;
            var time = end - start;

            Console.WriteLine("Time: {0}", time);
        }
    }
}
