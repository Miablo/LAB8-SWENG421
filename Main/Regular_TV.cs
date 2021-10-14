using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Regular_TV : AbsTV
    {
        // MSRP
        private int price = 200;

        // sest price
        public void setPrice(int p)
        {
            this.price = p;
        }
        
    }
}
