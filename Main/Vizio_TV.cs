using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Vizio_TV : TV_IF, BrandIF
    {
      // MSRP 250
     
        public string getBrand()
        {
            return "Vizio";
        }

        public void getInfo()
        {
            Console.WriteLine("Brand: " + getBrand());
            Console.WriteLine("\n");
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("This is from Vizio TV Regular\n");
        }

        public int getPrice()
        {
            return 250;
        }

        public string getType()
        {
            throw new NotImplementedException();
        }
    }
}
