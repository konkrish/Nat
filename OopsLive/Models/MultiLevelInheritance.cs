using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class MultiLevelInheritance
    {
        public void Base()
        {
            Console.WriteLine("Base");
        }
    }

    public class DerivedOne : MultiLevelInheritance
    {
        public void Derived1()
        {
            Console.WriteLine("Derived One");
        }
    }

    public class DerivedTwo : DerivedOne
    {
        public void Derived2()
        {
            Console.WriteLine("Derived two");
        }
    }
}