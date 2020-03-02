//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    internal class Employee
//    {
//        static public Employee _inst;
//        public Int32 GetYearsEmployed() { return 0; }
//        public virtual String GetProgressReport() { return null; }
//        public static string Hello(String name) { return "Hello " + name; }
//    }

//    internal class Manager : Employee
//    {
//        public static new string Hello(String name) { return "HELLO " + name; }
//    }


//    class Study_Virtual_Static
//    {
//        static void Main(string[] args)
//        {
//            Employee e = new Employee();
//            Manager m = new Manager();

//            Console.WriteLine(Employee.Hello("kai"));
//            Console.WriteLine(Manager.Hello("kai"));
//        }
//    }
//}
