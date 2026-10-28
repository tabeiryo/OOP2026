using Exercise03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exercise03
{
    public class LineCounter : ITextFileService
    {
        

            private int _count = 0;
        

            public void Initialize(string fname) =>
                _count = 0;

        public void Execute(string line)
        {
            _count++;
            if (_count < 20)
            {
                Console.WriteLine(line);
            }
        }

        public void Terminate() =>
                Console.WriteLine("{0} 行", _count);

        

    }
}
