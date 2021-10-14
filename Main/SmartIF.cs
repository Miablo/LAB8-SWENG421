using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    interface SmartIF
    {
        // A Smart_TV object further has a “~getPowerUsage(): double” method
        // to display 5.5 watts power usage per hour. 

        double getPowerUsage();
        public void getInfo();
        public int getPrice();
        public String getType();
    }
}
