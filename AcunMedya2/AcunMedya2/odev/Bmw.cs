using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.odev
{
    public class Bmw:Fast, Swim, Fly
    {
        public void fly()
        {
            Console.WriteLine("Bmw ucar");
        }   

    
        public void fast()
        {
            Console.WriteLine("Bmw hızlıdır");
        }
        public void swim()
        {
            Console.WriteLine("Bmw yüzer");
        }
    }
   
}
