using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class Principal
    {
        public void Monitor()
        {
            Console.WriteLine("Monitor");
        }    }
    class Teacher : Principal
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
    class Student : Principal
    {
        public void Learn()
        {
            Console.WriteLine("Learn");
        }
    }
}