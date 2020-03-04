//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace CSharpStudy
//{
//    public static class Extension
//    {
//        public static void InvokeAndCatch<TException>(this Action<Object> d, Object o) where TException : Exception
//        {
//            try { d(o); }
//            catch (TException) { }
//        }
//    }
//    class Study_Lambda
//    {
//        private static void Main(string[] args)
//        {
//            study_extension_method();
//        }

//        private static void study_lambda_function()
//        {
//            Thread t = new Thread(obj => { Console.WriteLine("ThreadFunc in anonymous method called!"); }) ;
//            t.Start();
//            t.Join();
//        }

//        private static void study_extension_method()
//        {
//            Action<Object> action = o => Console.WriteLine(o.GetType());
//            action.InvokeAndCatch<NullReferenceException>(null); // 예외 발생 x
//            action(null); // 예외 발생
            
//        }
//    }
//}
