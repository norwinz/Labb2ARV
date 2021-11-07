using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Dog : Djur
    {
        public string Fur = "Short";
        public Dog(string race, int eyes, int legs, string color, string sound, bool liveinwater, string fur)
        :base(race, eyes, legs, color, sound, liveinwater)
        {
            this.Fur = fur;
        }
        
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
            if(Legs == 4)
            {
                Console.WriteLine("This dog have all legs =)");
            }
        }
    }
}
