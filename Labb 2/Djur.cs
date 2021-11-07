using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Djur
    {
        public string Race;
        public int Eyes, Legs;
        public string Color, Sound;
        public bool LiveInWater;


        /*public Djur(int Eyes, int Legs, string Color, string Sound, bool LiveInWater)
            {
            _Eyes = Eyes;
            _Legs = Legs;
            _Color = Color;
            _Sound = Sound;
            _LiveInWater = LiveInWater;
            }*/
        public void makeSound()
        {
            Console.WriteLine("{0} goes {1}", Race, Sound);
        }
        public void printdata()
        {
            Console.WriteLine("This is a {0}. It has {1} eyes and {2} legs. Its color is {3}.", Race, Eyes, Legs, Color);
        }
        public void LIW()
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
