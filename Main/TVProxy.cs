using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TVProxy : Regular_TV, TV_IF
    {
        Regular_TV tv = new Regular_TV();
        TV_IF tif;

        public TVProxy()
        {
            new Regular_TV();
        }
    }
}
