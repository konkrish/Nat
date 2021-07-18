using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    abstract class Abstraction//Abstract Class
    {
        public abstract void animalSound();//Abstract Method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Abstraction)
    class DerivedPig : Abstraction
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}