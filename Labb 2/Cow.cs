using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Cow : Djur
    {
        public int Age = 4;
        public Cow(string race, int eyes, int legs, string color, string sound, bool liveinwater, int age)
        :base(race, eyes, legs, color, sound, liveinwater)
        {
            this.Age = age;
        }
        

        public void datawithage()
        {
            printdata();
            Console.WriteLine("Its age is {0}.", Age);
        }
        

    }
}
