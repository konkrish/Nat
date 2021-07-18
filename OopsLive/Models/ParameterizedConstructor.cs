using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class ParameterizedConstructor
    {
        public int Num;
        public string Test;

        //Nullable parameter syntax in constructor - >int num, string test = null
        public ParameterizedConstructor(int num, string test)
        {
            this.Num = num;
            this.Test = test;
        }
    }
}