using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Chihuahua : Dog
    {
        public int Weight = 2;
        public Chihuahua(string race, int eyes, int legs, string color, string sound, bool liveinwater, string fur, int weight)
         :base(race, eyes, legs, color, sound, liveinwater, fur)
        {
            this.Weight = weight;
        }
        public void chiaData()
        {
        printdata();
            furData();
            Console.WriteLine("It weight {0} kg.", Weight);
        }
    }
}
