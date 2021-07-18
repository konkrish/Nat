using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class DestExample
    {
        public DestExample()
        {
            Console.WriteLine("An Instance of classcalled");
        }

        ~DestExample()
        {
            Console.WriteLine("An Instance of class for  destroyed");
        }
    }
    class Program
    {
        //Constructor
        public Program()
        {
            Main(null);
        }
        static void Main(string[] args)
        {
            Details();
            System.GC.Collect();
            Console.ReadLine();
        }
        public static void Details()
        {
            // Created instance of the class
            DestExample user = new DestExample();
        }
    }
}