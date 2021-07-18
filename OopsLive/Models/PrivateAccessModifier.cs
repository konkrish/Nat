using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class PrivateAccessModifier
    {
        // Member is declared as private
        private int value;

        // value is Accessible 
        // only inside the class
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }

    class Child : PrivateAccessModifier
    {

        public void showValue()
        {
            //Console.WriteLine( "Value = " + value );
        }
    }
}