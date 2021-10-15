using Main;
using System;

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
                    if(budget <= 450 && budget > 400)
                    {
                        // vizio ultra 450
                        tv = new TVProxy(3);
                    } else if(budget <= 480 && budget > 450)
                    {
                        // sony ultra 480
                        tv = new TVProxy(1);
                    } else
                    {
                        // 400 ultra hd
                        tv = new UltraHD_TV();
                        tv.getInfo();  
                    }

                    break;
                case >= 300:
                    if (budget <= 350 && budget > 300)
                    {
                        // vizio smart 350
                        tv = new TVProxy(2);
                    }
                    else if (budget <= 380 && budget > 350)
                    {
                        // sony smart 380
                        tv = new TVProxy(0);
                    }
                    else
                    {
                        // 300 smart
                        tv = new Smart_TV();
                        tv.getInfo();
                    }
                    break;
                case >= 200:

                    if (budget <= 250 && budget > 200)
                    {
                        // vizio regular 250
                        tv = new TVProxy(4);
                    }
                    else if (budget <= 280 && budget > 250)
                    {
                        // sony regular 280
                        tv = new TVProxy(5);
                    }
                    else
                    {
                        // 200 regular
                        tv = new Regular_TV();
                        tv.getInfo();
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
