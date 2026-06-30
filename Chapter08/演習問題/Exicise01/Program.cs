
using Microsoft.VisualBasic;
using System.Text;

namespace Exicise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exicise01(text);
            Console.WriteLine();
            Exicise02(text);
        }

        private static void Exicise01(string text)
        {
            //var dict =new Dictionary<char,int>();
            //foreach(var sh in text.ToUpper()){
            //if('A'<= sh && sh<='Z'){
            //if(dict.ContainsKey){
            //dict[sh]++;
            //}else dict[sh]=1;
            //}
            //}
            //foreach(var item in dict.OrderBy(x=>x.Key)){
            //Console.WriteLine("[0]:[1]",item.Key,item.value);
            //}
            int ant =0;
            int bnt=0;
            int cnt = 0;
            int dnt = 0;
            int ent = 0;
            int fnt = 0;
            int gnt = 0;
            int hnt = 0;
            int icnt = 0;
            int jnt = 0;
            int knt = 0;
            int nnt = 0;
            int mnt = 0;
            int lnt = 0;
            int ont = 0;
            int pnt = 0;
            int qnt = 0;
            int rnt = 0;
            int snt = 0;
            int tnt = 0;
            int unt = 0;
            int vnt = 0;
            int wnt = 0;
            int xnt = 0;
            int ynt = 0;
            int znt = 0 ;
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words) {
                foreach (var w in word)
                {
                    if (w=='a' || w=='A')
                    {
                        ant += 1;
                    }
                    else if (w=='b'||w=='B')
                    {
                        bnt += 1;
                    }
                    else if (w == 'c' || w == 'C')
                    {
                        cnt += 1;
                    }
                    else if (w == 'd' || w == 'D')
                    {
                        dnt += 1;
                    }
                    else if (w == 'e' || w == 'E')
                    {
                        ent += 1;
                    }
                    else if (w == 'f' || w == 'F')
                    {
                        fnt += 1;
                    }
                    else if (w == 'g' || w == 'G')
                    {
                        gnt += 1;
                    }
                    else if (w == 'h' || w == 'H')
                    {
                        hnt += 1;
                    }
                    else if (w == 'i' || w == 'I')
                    {
                        icnt += 1;
                    }
                    else if (w == 'j' || w == 'J')
                    {
                        jnt += 1;
                    }
                    else if (w == 'k' || w == 'K')
                    {
                        knt += 1;
                    }
                    else if (w == 'n' || w == 'N')
                    {
                        nnt += 1;
                    }
                    else if (w == 'm' || w == 'M')
                    {
                        mnt += 1;
                    }
                    else if (w == 'l' || w == 'L')
                    {
                        lnt += 1;
                    }
                    else if (w == 'o' || w == 'O')
                    {
                        ont += 1;
                    }
                    else if (w == 'p' || w == 'P')
                    {
                        pnt += 1;
                    }
                    else if (w == 'q' || w == 'Q')
                    {
                        qnt += 1;
                    }
                    else if (w == 'r' || w == 'R')
                    {
                        rnt += 1;
                    }
                    else if (w == 's' || w == 'S')
                    {
                        snt += 1;
                    }
                    else if (w == 't' || w == 'T')
                    {
                        tnt += 1;
                    }
                    else if (w == 'u' || w == 'U')
                    {
                        unt += 1;
                    }
                    else if (w == 'v' || w == 'V')
                    {
                        vnt += 1;
                    }
                    else if (w == 'w' || w == 'W')
                    {
                        wnt += 1;
                    }
                    else if (w == 'x' || w == 'X')
                    {
                        xnt += 1;
                    }
                    else if (w == 'y' || w == 'Y')
                    {
                        ynt += 1;
                    }
                    else if (w == 'z' || w == 'Z')
                    {
                        znt += 1;
                    }
                }
            }
            if (ant > 0)
            {
                Console.WriteLine("'A':" + ant);
            }
            else if (bnt > 0) {
                Console.WriteLine("'B':" + bnt); 
            }
            else if (cnt > 0)
            {
                Console.WriteLine("'C':" + cnt);
            }
            else if (dnt > 0)
            {
                Console.WriteLine("'D':" + dnt);
            }
            else if (ent > 0)
            {
                Console.WriteLine("'E':" + ent);
            }
            else if (fnt > 0)
            {
                Console.WriteLine("'F':" + fnt);
            }
            else if (gnt > 0)
            {
                Console.WriteLine("'G':" + gnt);
            }
            else if (hnt > 0)
            {
                Console.WriteLine("'H':" + hnt);
            }
            else if (icnt > 0)
            {
                Console.WriteLine("'I':" + icnt);
            }
            else if (jnt > 0)
            {
                Console.WriteLine("'J':" + jnt);
            }
            else if (knt > 0)
            {
                Console.WriteLine("'K':" + knt);
            }
            else if (nnt > 0)
            {
                Console.WriteLine("'N':" + nnt);
            }
            else if (mnt > 0)
            {
                Console.WriteLine("'M':" + mnt);
            }
            else if (lnt > 0)
            {
                Console.WriteLine("'L':" + lnt);
            }
            else if (ont > 0)
            {
                Console.WriteLine("'O':" + ont);
            }
            else if (pnt > 0)
            {
                Console.WriteLine("'P':" + pnt);
            }
            else if (qnt > 0)
            {
                Console.WriteLine("'Q':" + qnt);
            }
            else if (rnt > 0)
            {
                Console.WriteLine("'R':" + rnt);
            }
            else if (snt > 0)
            {
                Console.WriteLine("'S':" + snt);
            }
            else if (tnt > 0)
            {
                Console.WriteLine("'T':" + tnt);
            }
            else if (unt > 0)
            {
                Console.WriteLine("'U':" + unt);
            }
            else if (vnt > 0)
            {
                Console.WriteLine("'V':" + vnt);
            }
            else if (wnt > 0)
            {
                Console.WriteLine("'W':" + wnt);
            }
            else if (xnt > 0)
            {
                Console.WriteLine("'X'"+xnt);
                        }
            else if (ynt > 0)
            {
                Console.WriteLine("'Y'" + ynt);
            }
            else if (znt > 0)
            {
                Console.WriteLine("'Z'" + znt);
            }

        }

        private static void Exicise02(string text)
        {
            
            ; int i = 0;
            var tevt = text.ToUpper();
            var words = tevt.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in words) {
                foreach (var item in word)
                {
                    
                       
                }
                
            }
            
           
            
        }
    }
}
