using OopsLive.Models;
using OopsLive.Models.MultipleInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static OopsLive.Models.ProtectedAccessModifier;

namespace OopsLive.Controllers
{
    //[CustomExceptionHandlerFilter]
    //clsss -> Memmbers and MF
    public class HomeController : Controller
    {
        //public int Num = 0;//Member 4KB
        //public string Test = "shjdh";//Member 10KB

        //public void Print() //Member function 0KB
        //{

        //}
        //HomeController obj = new HomeController();//Heap 14KB


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //DefaultConstructor
            DefaultConstructor df = new DefaultConstructor();
            Console.WriteLine(df.Num);
            df.Test = "SS";
            Console.WriteLine(df.Test);

            //ParameterizedConstructor
            ParameterizedConstructor pc = new ParameterizedConstructor(1, "Parameter");
            Console.WriteLine(pc.Num);
            Console.WriteLine(pc.Test);

            //CopyConstructor
            CopyConstructor cc1 = new CopyConstructor("June", 2018);
            CopyConstructor cc2 = new CopyConstructor(cc1);
            Console.WriteLine(cc2.Details);

            //PrivateConstructor
            //PrivateConstructor pc = new PrivateConstructor();
            PrivateConstructor.GetCount();
            Console.WriteLine(PrivateConstructor.count);

            //StaticConstructor 
            StaticConstructor obj = new StaticConstructor(1);
            Console.WriteLine(obj.GetDetail("First", 1));
            StaticConstructor obj1 = new StaticConstructor(2);
            Console.WriteLine(obj1.GetDetail("Second", 2));

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Properties
        public void Properties()
        {
            Properties myObj = new Properties();
            Console.WriteLine(myObj.Name);
            myObj.Name = "Test String";
            Console.WriteLine(myObj.Name);
        }

        //PublicAccessModifier
        public void PublicAccessModifier()
        {
            PublicAccessModifier obj = new PublicAccessModifier(4, "Test");
            Console.WriteLine("number: {0}", obj.name);
            Console.WriteLine("Name: {0}", obj.name);
            Console.WriteLine("number: {0}", obj.getRollNo());
        }

        //ProtectedAccessModifier
        public void ProtectedAccessModifier()
        {
            ProtectedAccessModifier obj1 = new ProtectedAccessModifier();
            //int i = obj1.x;
            DervidedClass obj2 = new DervidedClass();
            Console.WriteLine("Value of x is : {0}", obj2.getX());
        }

        public void InternalAccessModifier()
        {
            InternalAccessModifier obj = new InternalAccessModifier();
            //int i =obj.real;
        }

        //Inheritance
        public void Inheritance()
        {
            DerivedClass obj = new DerivedClass();
            obj.readers("Kirtshna", "C#");
        }

        //HierarchicalInheritance
        public void HierarchicalInheritance()
        {
            Principal g = new Principal();            g.Monitor();            Teacher d = new Teacher();            d.Monitor();            d.Teach();            Student s = new Student();            s.Monitor();            s.Learn();
        }

        //MultiLevelInheritance
        public void MultiLevelInheritance()
        {
            DerivedTwo derived2 = new DerivedTwo();
            derived2.Derived1();
            derived2.Base();
        }

        //Polymorphism
        public void Polymorphism()
        {
            Polymorphism myAnimal = new Polymorphism();  // Create a Animal object
            Polymorphism myPig = new Pig();  // Create a Pig object
            Polymorphism myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }

        //StaticPolymorphism
        public void StaticPolymorphism()
        {
            StaticPolymorphism obj = new StaticPolymorphism();
            int sum1 = obj.Add(1, 2);
            int sum2 = obj.Add(1, 2, 3);
            double sum3 = obj.Add(1.0, 2.0, 3.0);
            obj.Identity("Krishna", 1);
            obj.Identity(2, "chaitanya");
        }

        //Abstraction
        public void Abstraction()
        {
            //Abstraction obj = new Abstraction();

            DerivedPig myPig = new DerivedPig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }

        //Interfaces
        public void Interfaces()
        {
            InterfaceClass bicycle = new InterfaceClass();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);
            bicycle.printStates();
        }

        //MultipleInterface
        public void MultipleInterface()
        {
            ClassC obj = new ClassC();
            obj.ClassAMethod();
            obj.ClassBMethod();
            obj.ClassCMethod();
        }

        //Enum
        public void Enum()
        {
            EnumClass enumClass = new EnumClass();
            enumClass.Observe();
        }

        //Exceptions
        public void Exceptions()
        {
            Exceptions obj = new Exceptions();
            obj = null;
            //obj.ExceptionMethod();
        }

        //Files
        public void Files()
        {
            Files obj = new Files();
            obj.TestFiles();
        }

        //Desctructor
        public void Desctructor() {
            Program obj = new Program();
        }
    }
}