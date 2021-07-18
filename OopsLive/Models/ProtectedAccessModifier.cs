using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class ProtectedAccessModifier
    {
        //Protected Member
        protected int x;

        public ProtectedAccessModifier()
        {
            x = 10;
        }
        public void Cal()
        {
            int y = x * 10;
        }
        public class DervidedClass : ProtectedAccessModifier
        {
            // Members of Y can access 'x'
            public int getX()
            {
                x = x * 10;
                return x;
            }
        }
    }
}