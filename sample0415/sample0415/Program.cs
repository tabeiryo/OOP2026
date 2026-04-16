namespace sample0415
{
    internal class Program
    {
         static void ast0ut(int num){
            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {
            int[] y = new int[10];
            int sum = 0;

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("数字を入力");
                string? inputnum = Console.ReadLine();
                int x = int.Parse(inputnum);
                y[i] = x;
                sum = sum + y[i];
            }


            for (int j = 0; j < y.Length; j++)
            {
                ast0ut(y[j]);

                Console.WriteLine();
            }
            
            Console.WriteLine("合計:" + sum);
        }
    }
}
