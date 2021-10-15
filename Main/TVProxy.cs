using System;

namespace Main
{
    public class TVProxy : AbsTVGlobal
    {
        Regular_TV tv = new Smart_TV(); // polymorphism
        TV_IF tif;

        public TVProxy(int index)
        {
             getObject(index);
            
        }

        public void getObject(int index)
        {
            

            switch (index)
            {
                case 0:
                    tif = new Sony_Smart_TV();
                    base.setPrice(380);
                    base.setType("Smart");
                    Console.WriteLine("Smart Sony!\n");
                    break;
                case 1:
                    tif = new Sony_UltraHD_TV();
                    base.setPrice(480);
                    base.setType("Ultra");
                    Console.WriteLine("Ultra Sony!\n");
                    break;
                case 2:
                    tif = new Vizio_Smart_TV();
                    base.setPrice(350);
                    Console.WriteLine("Smart Vizio!\n");
                    break;
                case 3:
                    tif = new Vizio_UltraHD_TV();
                    base.setPrice(450);
                    Console.WriteLine("Ultra Vizio!\n");
                    break;
                default:
                    break;
            }

            tif.getInfo();

           
        }

    }
}
