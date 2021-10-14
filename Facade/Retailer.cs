using Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Retailer
    {
        Regular_TV tv;

        public TV_IF replenishTV(int budget)
        {
            // 200 regular
            // 300 smart
            // 400 ultra hd
            object o = new object();
            switch(budget)
            {
                case >= 400:
                    return UltraHD_TV();
                
            }
           
        }
       

    }
}
