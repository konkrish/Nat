using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class StaticConstructor
    {
        //First time only and One time only
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor");
        }
        public StaticConstructor(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }
        public string GetDetail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }

        //Members/Parameters/Variables/Objects(AM)
        //Constructors
        //Functions/MemberFunctions(AM)
        //10keys - 10Values
    }
}