using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Cow : Djur
    {
        public int Age =4;

        public void datawithage()
        {
            printdata();
            Console.WriteLine("Its age is {0}.", Age);
        }
        

    }
}
