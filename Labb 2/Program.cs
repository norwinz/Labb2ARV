//Dan Gustafsson SUT-21 LABB 2 ARV
using System;

namespace Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Cow Cow1 = new Cow("Cow", 2, 4, "Black", "Mooo", false, 8);
            
            Fish Fish1 = new Fish("Fish", 2, 0, "Orange", "Blob", true, "River");

            Dog Dog1 = new Dog("Dog", 2, 3, "Black", "WAFF", false, "Long");
            
            Bulldog Bulldog1 = new Bulldog("Bulldog", 2,4,"White","Woff",false,"Short","40cm");
           
            Chihuahua Chihuahua1 = new Chihuahua("Chihuahua",2,4,"Brown","Wuff",false,"Long",2);
            

            Cow1.makeSound();
            Fish1.makeSound();            
            Bulldog1.makeSound();
            Chihuahua1.makeSound();
            Console.WriteLine("--------------");
            Fish1.printdata();
            Fish1.LIW();
            Console.WriteLine("--------------");
            Cow1.datawithage();
            Cow1.LIW();
            Console.WriteLine("--------------");
            Fish1.fishData();
            Console.WriteLine("--------------");           
            Chihuahua1.chiaData();
            Chihuahua1.allLegs();
            Console.WriteLine("--------------");
            Bulldog1.bulldogData();
            Console.WriteLine("--------------");
            Dog1.printdata();
            Dog1.furData();
            Dog1.allLegs();
        }
    }
}
