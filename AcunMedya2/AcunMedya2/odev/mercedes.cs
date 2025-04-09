using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.odev
{
    internal class mercedes : Fast, Fly
    {
      
    
        public void fly()
        {
            Console.WriteLine("mercedes ucar");
        }


        public void fast()
        {
            Console.WriteLine("mercedes hızlıdır");
        }
    }
}
