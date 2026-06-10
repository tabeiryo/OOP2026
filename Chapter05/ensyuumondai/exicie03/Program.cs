namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        public record YearMonth { 
        public required int Year { get; init; }
            public required int Month { get; init; }

            public YearMonth(int year, int month)
            {
                Year = year;
                Month = month;
            }

            public bool Is21Century => 2001 <= Year && Year <= 2100;

            public YearMonth AddOneMonth()
            {
                if (Month <= 11)
                {
                    return new YearMonth(Year, Month + 1); 
                }
                else
                {
                    return new YearMonth(Year + 1, 1);
                }
            }

            public override string ToString() => $"{Year}年{Month}月";
        }



    }
}
