using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleEscape
{
    class KhadrasRum
    {
        public void FørsteRum() {
            Console.WriteLine("Hvilken måned på året har 28 dage?");
            string svar = Console.ReadLine();

            if (svar.ToLower() == "februar")
            {
                Console.WriteLine("Nope");
            }
            else if (svar.ToLower() == "alle") 
            {
                Console.WriteLine("Korrekt");
            }
            else
            {
                Console.WriteLine("Ugyldig input");
                
            }
            
            Console.ReadLine();
        }
    }
}
