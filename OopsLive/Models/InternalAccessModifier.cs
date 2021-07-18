using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    internal class InternalAccessModifier
    {
        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    // Driver Class
    class Driver
    {
        // Main Method
        static void Main(string[] args)
        {
            InternalAccessModifier c = new InternalAccessModifier();
            c.setData(2, 1);
            c.displayData();
        }
    }
}