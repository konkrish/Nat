using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    //Base class
    public class Inheritance
    {
        public string name;
        public string subject;

        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    //Derrived Class
    //Can inherit single class at a time 
    //Can inherit multiple interfaces at a time
    class DerivedClass : Inheritance
    {
        // constructor of derived class
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass");
        }
    }
}