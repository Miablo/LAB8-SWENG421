using System;

namespace Main
{
    class Vizio_TV : AbsTVGlobal, BrandIF
    {
        // MSRP 250

        public Vizio_TV()
        {
            Console.WriteLine("Brand: " + getBrand());
            setType("Regular");
            setPrice(250);
        }
     
        public string getBrand()
        {
            return "Vizio";
        }
   
    }
}
