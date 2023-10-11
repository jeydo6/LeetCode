using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1185
    {
        public String DayOfTheWeek(Int32 day, Int32 month, Int32 year)
        {
            //DateTime dt = new DateTime(year, month, day);

            //return dt.DayOfWeek
            //    .ToString();

            // 1971-01-01 -> Friday
            String[] daysOfWeek = new String[7]
            {
                "Friday",
                "Saturday",
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday"
            };

            Int32[] daysOfMonth = new Int32[12]
            {
                31,
                28,
                31,
                30,
                31,
                30,
                31,
                31,
                30,
                31,
                30,
                31
            };

            if (year % 4 == 0)
            {
                daysOfMonth[1] = 29;
            }

            Int32 result = day - 1;

            for (Int32 i = 0; i < month - 1; i++)
            {
                result += daysOfMonth[i];
            }

            for (Int32 i = 1971; i < year; i++)
            {
                if (i % 4 == 0)
                {
                    result += 366;
                }
                else
                {
                    result += 365;
                }
            }

            return daysOfWeek[result % daysOfWeek.Length];
        }
    }
}
