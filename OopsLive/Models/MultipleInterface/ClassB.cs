using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models.MultipleInterface
{
    public class ClassB : InterfaceB
    {
        public void ClassBMethod()
        {
            Console.WriteLine("ClassBMethod");
        }
    }
}