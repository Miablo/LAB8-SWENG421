
namespace Main
{
    public class TVProxy : AbsTVGlobal
    {
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
                    
                    break;
                case 1:
                    tif = new Sony_UltraHD_TV();
                    
                    break;
                case 2:
                    tif = new Vizio_Smart_TV();
                    
                    break;
                case 3:
                    tif = new Vizio_UltraHD_TV();
                   
                    break;
                case 4:
                    tif = new Vizio_TV();
                    
                    break;
                case 5:
                    tif = new Sony_TV();
                    
                    break;
                default:
                    break;
            }

            tif.getInfo();

           
        }

    }
}
