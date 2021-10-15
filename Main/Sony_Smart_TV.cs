using System;

namespace Main
{
    class Sony_Smart_TV : Sony_TV, SmartIF
    {
        double powerWattage = 5.15;
        // MSRP 380
        public double getPowerUsage()
        {
            return powerWattage;
        }

        public Sony_Smart_TV()
        {
            setPrice(380);
            
            setType("Smart");
            Console.WriteLine("Power Usage: " + getPowerUsage());
        }


        
    }
}
