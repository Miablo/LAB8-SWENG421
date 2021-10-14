using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Smart_TV : Regular_TV
    {
        // A Smart_TV object further has a “~getPowerUsage(): double” method to display 5.5 watts power usage per hour
        public Smart_TV sTV;
        double powerWatt = 5.5;

        internal double getPowerUsage()
        {
            return powerWatt;
        }

       
    }
}
