using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distanceconverter
{
    public class FeetConverter
    {
        private const double ra  = 0.3048;

        public　static double Frommetar(double meter) {
            return meter / ra;
        }

        public static double tometer(double feet)
        {
            return feet * ra;
        }
        }
}
