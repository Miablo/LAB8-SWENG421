using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Regular_TV
    {
       
        // MSRP
        private int price = 200;
        private string type = "Regular";
 
        // set price
        internal void setPrice(int price)
        {
            this.price = price;
        }

        public string getType()
        {
            return type;
        }

        public int getPrice()
        {
            return price;
        }

        public void getInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("This is from Regular TV\n");
            Console.WriteLine("Type: \n" + getType());
        }

        public void setType(string s)
        {
            this.type = s;
        }



    }
}
