//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    class Person
//    {
//        public string name;
//        public int age;

//        public Person() { }
//        public Person(string _name, int _age) { name = _name; age = _age; }
//    }
//    class Study
//    {
//        private static void Main(string[] args)
//        {

//            Person p2 = new Person("Hello", 999);
            
//            PrintAddress(ref p2);
//            PrintStat(ref p2);
//            ChangeStat(ref p2);
//            PrintStat(ref p2);
//        }


//        static void PrintAddress(ref Person o)
//        {
//            Console.WriteLine(o);
//        }
//        static void ChangeStat(ref Person p)
//        {
//            p.name = "Kai";
//            p.age = 27;
//        }
//        static void PrintStat(ref Person p)
//        {
//            Console.WriteLine($"{p.name} : {p.age}");
//        }
//    }
//}
