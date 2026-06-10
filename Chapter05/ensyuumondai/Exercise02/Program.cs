
using ensyuumondai;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.4");
            Exercise4(ymCollection);


            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) { Console.WriteLine(ym); }
        }

        private static void Exercise4(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                int ymup[];
                int p = 0;
                if (2000 < Year && Year <= 2100;)
                {
                    ymup[p] = ym;
                    p++;
                }
            }
            if (ymup[0] is null) {
                //return "null";
                return "21世紀のデータはありません"
            } else return ymup[0];
        }
        private static void Exercise5(YearMonth[] ymCollection) {
             foreach(var ym in ymCollection) {
                if (ym % 100 == 12)
                {
                    int setm = 13 - ym % 100;
                    int sety = ym / 100 + 1;
                    Console.WriteLine(sety + "年" + setm + "月");
                }
                else { 
                int setm = ym % 100 + 1;
                    int sety = ym / 100;
                    Console.WriteLine(sety + "年" + setm + "月");
                }

        }
    }
}
