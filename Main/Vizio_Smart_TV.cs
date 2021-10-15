
namespace Main
{
    class Vizio_Smart_TV : Vizio_TV, SmartIF
    {
        // MSRP 350
        double powerWattage = 6.35;

        public double getPowerUsage()
        {
            return powerWattage;
        }

        public Vizio_Smart_TV()
        {
            setPrice(350);
            setType("Smart");
            getBrand();
            getPowerUsage();
        }
    }
}
