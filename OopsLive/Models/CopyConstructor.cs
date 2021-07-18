using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class CopyConstructor
    {
        public string month;
        public int year;
        //Copy
        //Seccond call
        public CopyConstructor(CopyConstructor s)
        {
            month = s.month;
            year = s.year;
        }
        //First call
        public CopyConstructor(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }
    }
}