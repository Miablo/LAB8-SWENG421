using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TVProxy : Regular_TV, TV_IF
    {

        /*
         * public class ServiceProxy implements ServiceIF {
            ServiceIF[ ] sifa = new ServiceIF[2];
            public void doIt( ) {
          sifa[0] = new Service1( );
          sifa[1] = new Service2( );
          for(ServiceIF sif: sifa){
              sif.doIt( );
          }
    } 
}
         * 
         */
        Regular_TV tv = new Regular_TV();
        TV_IF[] tif = new TV_IF[8];

        public void getInfo()
        {
            tif[0] = new Sony_TV();
            tif[1] = new Sony_Smart_TV();
            tif[2] = new Sony_UltraHD_TV();
            tif[3] = new Vizio_TV();
            tif[4] = new Vizio_Smart_TV();
            tif[5] = new Vizio_UltraHD_TV();

            

        }
    }
}
