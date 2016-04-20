using Utilities;

namespace Problems
{
    public class Problem0019 : IProblem<int>
    {
        private readonly int[] monthsLength = new int[] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        public int Solve()
        {
            var sundaysFirstOfTheMonth = 0;

            var month = 0;
            var dayOfTheWeek = 0;
            var dayOfMonth = 0;

            for (var year = 1900; year <= 2000;)
            {
                var incrementMonth = false;

                if (year >= 1901 && year <= 2000)
                {
                    if (dayOfTheWeek == 6 && dayOfMonth == 0)
                    {
                        sundaysFirstOfTheMonth++;
                    }
                }

                dayOfTheWeek++;
                if (dayOfTheWeek > 6)
                {
                    dayOfTheWeek = 0;
                }

                dayOfMonth++;
                if (month == 1)
                {
                    if ((IsLeapYear(year) && dayOfMonth > 28) || dayOfMonth > 27)
                    {
                        incrementMonth = true;
                    }
                }
                else if (dayOfMonth >= monthsLength[month])
                {
                    incrementMonth = true;
                }

                if (incrementMonth == true)
                {
                    dayOfMonth = 0;
                    month++;
                    if (month > 11)
                    {
                        month = 0;
                        year++;
                    }
                }
            }

            return sundaysFirstOfTheMonth;
        }

        private bool IsLeapYear(int year)
        {
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }
    }
}