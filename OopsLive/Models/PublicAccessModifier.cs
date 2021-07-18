using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class PublicAccessModifier
    {
        public int rollNo;
        public string name;

        public PublicAccessModifier(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollNo;
        }
    }
}