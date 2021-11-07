﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Fish : Djur
    {
        public string OceanOrRiver = "Ocean";
        public Fish(string race, int eyes, int legs, string color, string sound, bool liveinwater, string oceanorriver)
        :base(race, eyes, legs, color, sound, liveinwater)
        {
            this.OceanOrRiver = oceanorriver;
        }
        
    public void fishData()
        {
            printdata();
            LIW();
            Console.WriteLine("This fish lives in {0}.", OceanOrRiver);
        }
    }
}
