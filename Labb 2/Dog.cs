using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Dog : Djur
    {
        public string Fur = "Short";
        public void furData()
        {
            Console.WriteLine("The {0} fur is {1}.", Race, Fur);
        }
        public void allLegs()
        {
            if(Legs<4)
            {
                Console.WriteLine("Poor doggy doesn't have all its legs =(");
            }
            if(Legs >4)
            {
                Console.WriteLine("This dog must be from Chernobyl");
            }
            else
            {
                Console.WriteLine("This dog have all legs =)");
            }
        }
    }
}
