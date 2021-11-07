using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Djur
    {
        public string Race ="Animal";
        public int Eyes=2, Legs =4;
        public string Color="Color", Sound="Sound";
        public bool LiveInWater = false;


        /*public Djur(int CEyes, int CLegs, string CColor, string CSound, bool CLiveInWater)
            {
            Eyes = CEyes;
            Legs = CLegs;
            Color = CColor;
            Sound = CSound;
            LiveInWater = CLiveInWater;
            }*/
        public void makeSound()
        {
            Console.WriteLine("{0} goes {1}", Race, Sound);
        }
        public void printdata()
        {
            Console.WriteLine("This is a {0}. It has {1} eyes and {2} legs. Its color is {3}.", Race, Eyes, Legs, Color);
        }
        public void LIW() // LIW = Live In Water
        {
            if (LiveInWater == true)
            {
                Console.WriteLine("{0} lives in water.", Race);
            }
            else
            {
                Console.WriteLine("{0} does not live in water.", Race);
            }
        }
    }
}
