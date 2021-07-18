using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models.MultipleInterface
{
    public class ClassA : InterfaceA
    {
        public void ClassAMethod()
        {
            Console.WriteLine("ClassAMethod");
        }
    }
}