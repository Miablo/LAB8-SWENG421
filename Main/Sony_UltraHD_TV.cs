using System;

namespace Main
{
    class Sony_UltraHD_TV : Sony_TV, UltraHDIF
    {
        // MSRP 480

        public Sony_UltraHD_TV()
        {
            setPrice(480);
            setType("Ultra");  
        }
        
    }
}
