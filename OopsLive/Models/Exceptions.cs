using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    class Exceptions
    {
        //public string test = "dsadsada";
        //public void ExceptionMethod()
        //{
        //    //Predefined
        //    try
        //    {
        //        int j = 8;
        //        //int i = j / 0;
        //    }
        //    catch (DivideByZeroException D)
        //    {
        //        Console.WriteLine(D.Message);
        //        throw;//Return 
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        ~Exceptions()
        {
            Console.WriteLine("Dest");
        }
    }
}