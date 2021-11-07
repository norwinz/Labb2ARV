using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Bulldog : Dog
    {
        public string Height = "40cm";
        public Bulldog(string race, int eyes, int legs, string color, string sound, bool liveinwater, string fur, string height)
        :base(race, eyes, legs, color, sound, liveinwater, fur)
        {
            this.Height = height;
        }
    
    
        
        public void bulldogData()
        {
            printdata();
            furData();
            Console.WriteLine("It is {0} high.", Height);
        }
    }
}
