using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class StaticPolymorphism
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        //We cant achive method overrloading with different return types.
        //public string Add(int a, int b, int c)
        //{
        //    int sum = a + b + c;
        //    return sum.ToString();
        //}

        public double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }

        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }
    }
}