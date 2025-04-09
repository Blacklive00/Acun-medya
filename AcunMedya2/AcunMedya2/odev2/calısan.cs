using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.odev2
{
    public abstract class calısan
    {

      public  abstract double salary();   


        


    }
    
   public class Genelmudur:calısan
    
    {
        public override double salary()
        {
            return 80000;    
        }


    }

    public class Mudur : calısan

    {
        public override double salary()
        {
            return 60000;
        }


    }


    public class programcı : calısan

    {
        public override double salary()
        {
            return 40000;
        }


    }



    public class Stajyer : calısan

    {
        public override double salary()
        {
            return 5000;
        }


    }

}
