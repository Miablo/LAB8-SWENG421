using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class AbsTV : TV_IF
    {
        private int price;

        public void getInfo()
        {
            throw new NotImplementedException();
        }

        public int getPrice()
        {
            return price;
        }

        public string getType()
        {
            throw new NotImplementedException();
        }

        internal void setPrice(int price)
        {
            this.price = price;
        }
    }
}
