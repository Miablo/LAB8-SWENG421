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
        private int price;
        private string type = string.Empty;

        public Regular_TV()
        {
            this.price = 200;
            this.type = "Regular";
        }
 
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
            Console.WriteLine("MSRP: " + getPrice());
            Console.WriteLine("Type: " + getType());
        }

        public void setType(string s)
        {
            this.type = s;
        }



    }
}
