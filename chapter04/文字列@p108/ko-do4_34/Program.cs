namespace ko_do4_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = "jjj";
            if (int.TryParse(str, out var height))
            {
                Console.WriteLine("へんかん成功");
            }
            else
                Console.WriteLine("変換できません");


        }
        try{int num = int.TryParse(str);
    }catch(Excaption){
    
}  