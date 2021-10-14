using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class AbsTV : TV_IF
    {
        string type;
        double powerWatt;
        int price;
        public void getInfo()
        {
            Console.WriteLine("Power Wattage:\n " + getPowerUsage());
            Console.WriteLine("Price:\n " + getPrice());
            Console.WriteLine("Type:\n " + getType());
        }

        double getPowerUsage()
        {
            return powerWatt;
        }

        int getPrice()
        {
            return price;
        }

        string getType()
        {
            return type;
        }

        void setPowerUsage(double wattage)
        {
            this.powerWatt = wattage;
        }

        void setPrice(int price)
        {
            this.price = price;
        }

        void setType(string type)
        {
            this.type = type;
        }
    }
}
