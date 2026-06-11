namespace exesise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();


            if (int.TryParse(str, out var suu))
            {
                Console.WriteLine($"{suu:#,0}");
            }
            else {
                Console.WriteLine("変換に失敗しました");
            }
        }
    }
}