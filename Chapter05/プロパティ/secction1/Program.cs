using System.Collections.Immutable;
using System.ComponentModel;
using System.Threading.Channels;

namespace secction1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new PasswordPolicy("sssssss", "bbbbbbb");
            var date = obj.Name;

            var ms = new MYsanpl();
            var newList = ms.Mylist.Add(6).Remove(0);
            ms.Mylist.foreach (n => Console.WriteLine($"{n}"))  ;
            Console.WriteLine();
            newList.foreach (n => Console.WriteLine($"{n}")) ;
            Console.WriteLine();



            foreach (var n in ms.Mylist) {
                Console.WriteLine(n);
        }
    }
    class MYsanpl {
        public ImmutableList<int>Mylist{ get; private set; }

        public MYsanpl() { 
        var List = new List<int>() { 1,2,3,4,5};
            Mylist = List;
        }
    }



    class PasswordPolicy { 
     public int MinimumLength { get; set; } = 8;

        public string Givename { get; init; } = null!;
        public string Famyname { get; init; }= null!;

       // public string Name {
       //     get { return Famyname + "" + Givename; }
       // }

        public string Name => Famyname + "" + Givename;

        public PasswordPolicy(string famyname, string givename)
        {
            Famyname = famyname;
            Givename = givename;
        }

        public void abd() {
            Givename = "gggg";
        }
 }
}
