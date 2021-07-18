using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models.MultipleInterface
{
    public class ClassC : InterfaceA, InterfaceB
    {
        public void ClassAMethod()
        {
            ClassA classA = new ClassA();
            classA.ClassAMethod();
        }

        public void ClassBMethod()
        {
            ClassB classB = new ClassB();
            classB.ClassBMethod();
        }


        public void ClassCMethod()
        {
            Console.WriteLine("ClassCMethod");
        }
    }
}