using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    //Base
    public class Polymorphism
    {
        //20
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    //Derived
    class Pig : Polymorphism
    {
        //10
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    //Derived
    class Dog : Polymorphism  
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}