using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class PrivateConstructor
    {
        //int i;//4KB
        private PrivateConstructor()
        {

        }

        //Non Static -> Object class ->Obj.membername
        //Static     -> ClassName.Membername
        //private int test = 0;
        public static int count;
        public static int GetCount()
        {
            return ++count;
        }
    }
}