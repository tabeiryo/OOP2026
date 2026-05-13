using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exiciez2
{
    public class FeetConverter2
    {
        private const double ra  = 0.3048;
        private const double qa = 0.0254;

        public　static double Frommetar(double meter) {
            return meter / ra;
        }

        public static double tometer(double feet)
        {
            return feet * ra;
        }
        public static double Frommetar2(double meter)
        {
            return meter / ra;
        }

        public static double tometer2(double inti)
        {
            return inti * ra;
        }
    }
}
