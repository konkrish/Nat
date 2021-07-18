using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class Properties
    {
        //Single Member -> Signle Property
        //Encapsulation
        private string name="Test"; // Member

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}