using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace OopsLive.Models
{
    public class Files
    {
        public void TestFiles()
        {
            string writeText = "Hello World!";
            string fileName = @"C:\Users\Lenovo\Desktop\LaptopCourier\NewFile.txt";
            File.WriteAllText(fileName, writeText);

            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);

            //AppendText()
            //Copy()
            //Delete()
            //Exists()
            //Replace()
        }
    }
}