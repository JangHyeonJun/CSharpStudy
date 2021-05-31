//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    class Study_Async_4
//    {
//        static void Main(string[] args)
//        {
//            Run1();
//        }

//        static void Run1()
//        {
//            var parentTask = Task.Run(() =>
//            {
//                var childTask = Task.Factory.StartNew(() =>
//                {
//                    Thread.Sleep(1000);
//                    Console.WriteLine("child task finished.");
//                }, TaskCreationOptions.AttachedToParent);

//                Console.WriteLine("parent task finished.");
//            });

//            parentTask.Wait();
//            Console.WriteLine("Main thread finished.");
//        }
//    }
//}
