//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//namespace CSharpStudy
//{
//    class Study_Async_1
//    {
//        private static void Main(string[] args)
//        {
//            Console.WriteLine("start");
//            Task t = WorkAsync();
            
//            Console.WriteLine("Do");
//            //t.Wait();
//        }

//        static Task WorkAsync()
//        {
//            return Task.Run(() => {
//                Thread.Sleep(1000);
//                Console.WriteLine("DoWorkAsync");
//            });
//        }
//    }
//}
