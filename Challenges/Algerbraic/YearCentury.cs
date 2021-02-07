using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Algerbraic
{
    public class YearCentury
    {
        public static int CenturyFromYear(int year)
        {
            if (year <= 100)
                return 1;

            int cYear = year / 100;
            if ((year % 10) == 0)
                return cYear;

            else return cYear + 1;
        }
    }
}
