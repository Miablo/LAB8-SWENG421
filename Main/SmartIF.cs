using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public interface SmartIF : TV_IF
    {
        // A Smart_TV object further has a “~getPowerUsage(): double” method
        // to display 5.5 watts power usage per hour. 

        double getPowerUsage();
    }
}
