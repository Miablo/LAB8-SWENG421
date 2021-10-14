using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Vizio_Smart_TV : Vizio_TV, SmartIF
    {
        double powerWattage = 6.35;
        public double getPowerUsage()
        {
            return powerWattage;
        }
    }
}
