namespace sample0413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("表示回数:");
            string? inputnum = Console.ReadLine(); //nyuuryoku

            int count= int.Parse(inputnum);
            int i = 1;
            while (true)
            {
                
                if ( i % 2==0){
                    Console.WriteLine(i + ".ttt");
                }
                if (i >= count) {
                    break;
                }
                i++;
            }
           

        }
    }
}
