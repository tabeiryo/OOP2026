namespace secction02
{
    internal class Program
    {
        static void Main(string[] args) {
            DoSomething(100);
            DoSomething(100,"エラー");
            DoSomething(100, "エラー", 5);ssss
        }

        public static void DoSomething(int num, string messege, int retryCount)
        {

        }
        public static void DoSomething(int num, string messege) { 
        DoSomething(num, messege, 3);
        }
        public static void DoSomething(int num) {
            DoSomething(num, "失敗しました",3);
        }

    }
}
