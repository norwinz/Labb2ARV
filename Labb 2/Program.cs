using System;

namespace Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Cow Cow1 = new Cow();
            Cow1.Race = "Cow";
            Cow1.Eyes = 2;
            Cow1.Legs = 4;
            Cow1.Color = "Black";
            Cow1.Sound = "Mooo";
            Cow1.LiveInWater = false;
            Cow1.Age = 8;

            Fish Fish1 = new Fish();
            Fish1.Race = "Fish";
            Fish1.Eyes = 2;
            Fish1.Legs = 0;
            Fish1.Color = "Orange";
            Fish1.Sound = "Blob";
            Fish1.LiveInWater = true;
            Fish1.OceanOrRiver = "River";

            Bulldog Bulldog1 = new Bulldog();
            Bulldog1.Race = "Bulldog";
            Bulldog1.Eyes = 2;
            Bulldog1.Legs = 4;
            Bulldog1.Color = "White";
            Bulldog1.Sound = "Woff";
            Bulldog1.LiveInWater = false;
            Bulldog1.Fur = "Short";
            Bulldog1.height = "40cm";

            Chihuahua Chihuahua1 = new Chihuahua();
            Chihuahua1.Race = "Chihuahua";
            Chihuahua1.Eyes = 2;
            Chihuahua1.Legs = 4;
            Chihuahua1.Color = "Brown";
            Chihuahua1.Sound = "Wuff";
            Chihuahua1.LiveInWater = false;
            Chihuahua1.Fur = "Long";
            Chihuahua1.weight = 2;

            Cow1.makeSound();
            Fish1.makeSound();            
            Bulldog1.makeSound();
            Chihuahua1.makeSound();
            Console.WriteLine("--------------");
            Fish1.printdata();
            Fish1.LIW();
            Console.WriteLine("--------------");
            Bulldog1.printdata();
            Bulldog1.LIW();
        }
    }
}
