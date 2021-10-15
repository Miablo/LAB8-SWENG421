using System;

namespace Main
{
    class Sony_TV : TV_IF, BrandIF
    {
        // MSRP 280
        
        public string getBrand()
        {
            return "Sony";
        }

        public void getInfo()
        {
            Console.WriteLine("Brand: " + getBrand());
            Console.WriteLine("\n");
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("This is from Sony TV Regular\n");
            Console.WriteLine("Type: \n" + getType());
        }

        public int getPrice()
        {
            return 280;
        }

        public string getType()
        {
            return "Regular\n";
        }

    }
}
