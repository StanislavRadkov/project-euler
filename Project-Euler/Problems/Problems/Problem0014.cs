using System.Collections.Generic;
using Utilities;

namespace Problems
{
    public class Problem0014 : IProblem<long>
    {
        private static Dictionary<long, long> cache = new Dictionary<long, long>(1000000);

        public long Solve()
        {

            var sequenceStart = -1L;
            var length = 1L;

            checked
            {
                for (var number = 1000000; number > 0; number--)
                {
                    var sequenceLength = GetCollatzSequenceLength(number);

                    cache.Add(number, sequenceLength);

                    if (sequenceLength <= length)
                    {
                        continue;
                    }

                    length = sequenceLength;
                    sequenceStart = number;
                }

                return sequenceStart;
            }
        }

        private static long GetCollatzSequenceLength(long number)
        {
            var count = 1L;
            checked
            {
                do
                {
                    if (cache.ContainsKey(number))
                    {
                        count += cache[number];
                        break;
                    }

                    if (number % 2 == 0)
                    {
                        number = number / 2;
                    }
                    else
                    {
                        number = number * 3 + 1;
                    }

                    count++;
                } while (number > 1);
            }
            return count;
        }
    }
}