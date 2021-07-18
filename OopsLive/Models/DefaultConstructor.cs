using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class DefaultConstructor
    {
        public int Num;
        public string Test;

        public DefaultConstructor()
        {
            Console.WriteLine("DF");
        }
    }
}