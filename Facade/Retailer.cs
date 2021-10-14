using Main;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    class Retailer
    {
        Regular_TV tv = new Regular_TV();
        int budget;
        public Retailer(int budget)
        {
            this.budget = budget;
        }
        public void replenishTV()
        {
            //closest too and below
            switch(budget)
            {
                case >= 400:
                    // 400 ultra hd
                    Console.WriteLine("Object is ultra\n");
                    
                    break;
                case >= 300:
                    // 300 smart
                    tv = new Smart_TV();
                    Console.WriteLine("Object is smart\n");
                    //tv.getInfo();
                    break;
                case >= 200:
                    // 200 regular
                    tv = new Regular_TV();
                    Console.WriteLine("Object is regular\n");
                   // tv.getInfo();
                    break;
                default:
                    tv = null;
                    Console.WriteLine("Object is null\n");
                    break;
            }
 
        }
    }
}
