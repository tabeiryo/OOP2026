using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    internal class FileName
    {
        public enum MerkaGroup { 
        なし,
                トヨタ,
                ニッサン,
                ホンダ,
                スバル,
                外車,
                その他,
        }

        public DateTime date { get; set; }
        SystemComponentModel
        public string authr { get; set; }=string .Empty;
        public MerkaGroup maker { get; set; }
        public string carName { get; set; } = string .Empty;
        public string Report { get; set; } = string.Empty;
        public Image? picture { get; set; }
    }
}
