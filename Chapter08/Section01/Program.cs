namespace Section01
{
    internal class Program
    {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();


        static void Main(string[] args)
        {
            string pref, prefCeptallocation;
            Console.WriteLine("県庁所在地の入力入力終了Ctrl+z");
            Console.WriteLine();

            while (true)
            {
                //都道府県
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) { break; }

                //県庁所在地
                Console.Write("県庁所在地:");
                prefCeptallocation = Console.ReadLine();
                if (prefCeptallocation == null) { break; }
                Console.WriteLine();

                //登録
                var keyd = pref;
                if (prefOfficeDict.ContainsKey(keyd))
                {
                    Console.WriteLine("都道府県が重複しています。上書きしますか？y/n");
                    string uwa = Console.ReadLine();
                    if (uwa=="y")
                    {
                        var fiind = prefOfficeDict[keyd];
                        bool resulte=prefOfficeDict.Remove(keyd);
                        prefOfficeDict.Add(pref, prefCeptallocation);
                    }
                } else prefOfficeDict.Add(pref, prefCeptallocation);

            }

            while (true)
            {
                //menu
                Console.WriteLine("*****メニュー*****");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                Console.WriteLine();

               string menu=Console.ReadLine();

                //終了
                if (menu == "9") { break; }

                //検索
                else if (menu == "2")
                {
                    Find();
                }
                //表示
                else if (menu == "1")
                {
                    Hyouji();
                }

                else break;
            }




        }
        private static void Hyouji() {
            foreach (var f in prefOfficeDict) { Console.WriteLine("[都道府県:" + f.Key + "][県庁所在地:" + f.Value + "]"); }
        }

        private static void Find() {
            Console.Write("都道府県:");
            string find = Console.ReadLine();
            var key = find;
            if (prefOfficeDict.ContainsKey(key))
            {
                var fiin = prefOfficeDict[key];
                Console.WriteLine(key + "の県庁所在地は" + fiin);
                Console.WriteLine();
            }
        }


    }
}
