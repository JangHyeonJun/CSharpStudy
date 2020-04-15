//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace CSharpStudy
//{
//    class Study_All
//    {
//        private static void Main(string[] args)
//        {
//            IEnumerable collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            var small = from int item in collection
//                        where item < 5
//                        select item;
//            var small2 = collection.Cast<int>().Where(item => item < 5).Select(n => n);

//            foreach (var n in small)
//                Console.Write($"{n} ");
//            Console.WriteLine();

//            foreach (var n in small2)
//                Console.Write($"{n} ");
//            Console.WriteLine();

//        }
//    }
//}
