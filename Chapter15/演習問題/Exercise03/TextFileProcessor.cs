using Exercise03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class TextFileProcessor
    {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
        _service = service;
        }
        
        public void Run(string filename) {
        _service.Initialize(filename);
            var lines = File.ReadLines(filename);

            
            foreach (var line in lines)
            {
                _service.Execute(line);
                
            }
            _service.Terminate();
        }
    }
}

