using System;

namespace Main
{
    class Vizio_UltraHD_TV : Vizio_TV, UltraHDIF
    {
        
        public Vizio_UltraHD_TV()
        {
            setPrice(450);
            
            setType("Ultra"); 
        }

    }
}
