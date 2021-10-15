using Main;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    class Retailer
    {
        Regular_TV tv;
        int budget;
        public Retailer(int budget)
        {
            this.budget = budget;
        }
        public void replenishTV()
        {
          
            //closest too and below
            switch (budget)
            {
                case >= 400:
                    // 400 ultra hd
                    
                    if(budget <= 450)
                    {
                        // vizio 450
                        tv = new TVProxy(1);
                    } else if(budget <= 480)
                    {
                        // sony 480
                        tv = new TVProxy(0);
                    } else
                    {
                        tv = new UltraHD_TV();
                        Console.WriteLine("Object is Ultra\n");     
                    }

                    break;
                case >= 300:
                    if (budget <= 350)
                    {
                        // vizio 350

                        tv = new TVProxy(1);
                    }
                    else if (budget <= 380)
                    {
                        // sony 380
                        tv = new TVProxy(2);
                    }
                    else
                    {
                        // 300 smart
                        tv = new Smart_TV();
                        Console.WriteLine("Object is smart\n");
                        tv.getPrice();
                        //tv.getInfo();
                    }
                    break;
                case >= 200:

                    // sony 280
                    tv = new Regular_TV();
                    Console.WriteLine("Object is regular\n");

                    if (budget <= 250)
                    {
                        // vizio 250
                        tv = new TVProxy(1);
                    }
                    else if (budget <= 280)
                    {
                        // sony 280
                        tv = new TVProxy(3);
                    }
                    else
                    {
                        // 200 regular
                        tv = new Regular_TV();
                        Console.WriteLine("Object is regular\n");
                        tv.getPrice();
                        //tv.getInfo();
                    }

                    break;
                default:
                    tv = null;
                    Console.WriteLine("Object is null\n");
                    break;
            }
 
        }
    }
}
