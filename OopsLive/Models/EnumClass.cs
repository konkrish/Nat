using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class EnumClass
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July,       // 6
            Augest      // 7
        }

        public void Observe()
        {
            string myMonth = Months.April.ToString();
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}