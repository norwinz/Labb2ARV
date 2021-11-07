using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Fish : Djur
    {
       public string OceanOrRiver ="Ocean";
    public void fishData()
        {
            printdata();
            LIW();
            Console.WriteLine("This fish lives in {0}.", OceanOrRiver);
        }
    }
}
