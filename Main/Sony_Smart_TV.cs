using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Sony_Smart_TV : Sony_TV, SmartIF
    {
        double powerWattage = 5.15;
        // MSRP 380
        public double getPowerUsage()
        {
            return powerWattage;
        }

        
    }
}
