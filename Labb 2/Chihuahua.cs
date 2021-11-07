using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2
{
    public class Chihuahua : Dog
    {
        public int weight = 2;
        public void chiaData()
        {
        printdata();
            furData();
            Console.WriteLine("It weight {0} kg.", weight);
        }
    }
}
