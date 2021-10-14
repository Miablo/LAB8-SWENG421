using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Sony_TV : AbsTV, BrandIF
    {
        
        public string getBrand()
        {
            return "Sony";
        }
        public Sony_TV()
        {

        }


    }
}
