using System;

namespace Main
{
    class Sony_TV : AbsTVGlobal, BrandIF
    {
        
        public string getBrand()
        {
            return "Sony";
        }

        public Sony_TV()
        {
            setPrice(280);
            Console.WriteLine("Brand: " + getBrand());
            setType("Regular");
        }

    }
}
