using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ensyuumondai
{
    public class YearMonth
    {
        public int Year { get; init; }
        public int Month { get; init; }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }
        public bool Is21Century()
        {
            return 2000 < Year && Year <= 2100;
        }
        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                int addyear = Year + 1;
                int setmonth = 13 - Month;
                YearMonth yearMonth = new YearMonth(addyear, setmonth);
                return yearMonth;
            }
            else
            {
                int setmonth = Month + 1;
                YearMonth yearMonth = new YearMonth(Year, setmonth);
                return yearMonth;
            }
        }
        public override string ToString()
        {
            return Year + "年" + Month + "月";
        }
    }
}
