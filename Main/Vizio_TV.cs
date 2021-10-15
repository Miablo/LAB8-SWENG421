using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Vizio_TV : AbsTVGlobal, BrandIF
    {
        // MSRP 250

        public Vizio_TV()
        {
            setType("Regular");
            setPrice(250);
            Console.WriteLine("Brand: " + getBrand());
        }
     
        public string getBrand()
        {
            return "Vizio";
        }
   
    }
}
