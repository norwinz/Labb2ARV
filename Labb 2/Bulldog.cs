using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Bulldog : Dog
    {
        public string height ="40cm";
        public void bulldogData()
        {
            printdata();
            furData();
            Console.WriteLine("It is {0} high.", height);
        }
    }
}
