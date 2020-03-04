//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    public sealed class People
//    {
//        public int age;
//        public string name;

//        public Object this[int key]
//        {
//            get
//            {
//                if (key == 1)
//                    return age;
//                else if (key == 2)
//                    return name;
//                return null;
//            }
//            set
//            {
//                if (key == 1)
//                    age = (int)value;
//                else if (key == 2)
//                    name = (string)value;
//            }
//        }
//        public Object this[string key]
//        {
//            get
//            {
//                if (key == "Age")
//                    return age;
//                else if (key == "Name")
//                    return name;
//                return null;
//            }
//            set
//            {
//                if (key == "Age")
//                    age = (int)value;
//                else if (key == "Name")
//                    name = (string)value;
//            }
//        }

//        public override string ToString()
//        {
//            return $"{name} : {age}";
//        }
//    }

//    class Study_Property
//    {
//        private static void Main(string[] args)
//        {
//            People p = new People { age = 27, name = "KAI" };
//            Console.WriteLine(p);
//            p["Age"] = 99;
//            Console.WriteLine(p);
//            Console.WriteLine(p["Name"]);
//            Console.WriteLine(p[1]);
//        }
//    }
//}
