//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;


///*
// * await 키워드를 쓰기 위해서는 메소드에 async 키워드를 붙여야한다.
// * await 키워드를 사용하면 새 스레드 2(백그라운드)를 만들어 비동기 task의 결과를 기다리도록 한다.
// * 
// * 비동기 메서드 호출한 기존의 스레드 1(Main)은 코드로 돌아와 자신의 일을 이어서 한다.
// * 
// * 결과를 기다리던 스레드 2는 task가 끝나면 끝난 부분부터 코드를 다시 실행한다(ContinueWith).
// */

//namespace CSharpStudy
//{
//    class Study_Async_3
//    {
//        static readonly int waitTime = 10;
//        static void Main()
//        {
//            Console.WriteLine("Run Main");
//            Calc4();
//            Console.WriteLine($"Wait {waitTime} second");
//            Thread.Sleep(1000 * waitTime);
//            Console.WriteLine("End Main Thread");
//            Thread.Sleep(99999999);
//        }

//        static async void Calc1()
//        {
//            Console.WriteLine("Run Calc1");
//            int sum = LongCalc(5);
//            Console.WriteLine($"Sum: {sum}");
//        }

//        static int LongCalc(int times)
//        {
//            int result = 0;
//            for (int i = 1; i <= times; i++)
//            {
//                result += i;
//                Thread.Sleep(1000);
//            }

//            return result;
//        }

//        static async void Calc2()
//        {
//            Console.WriteLine("Run Calc2");
//            int sum = await LongCalc2(10);
//            Console.WriteLine($"Sum: {sum}");
//        }

//        static async void Calc3()
//        {
//            Console.WriteLine("Run Calc3");
//            List<int> timeList = new List<int> { 4, 1, 2, 3, 5 };
//            int sum = 0;
//            foreach (var time in timeList)
//            {
//                Console.WriteLine($"{time} Thread Start");
//                var t = await Task.Run(() => LongCalc(time));
//                sum += t;
//            }

//            Console.WriteLine($"all calc end. sum : {sum}");
//        }

//        static async void Calc4()
//        {
//            Console.WriteLine("Run Calc4");
//            List<int> timeList = new List<int> { 4, 1, 2, 3, 5 };
//            List<Task<int>> taskList = new List<Task<int>>();
//            int sum = 0;
//            foreach (var time in timeList)
//            {
//                Console.WriteLine($"{time} Thread Start");
//                var t = Task.Run(() => LongCalc(time));
//                taskList.Add(t);
//            }

//            var resultList = await Task.WhenAll(taskList);

//            foreach (var result in resultList)
//            {
//                sum += result;
//            }

//            Console.WriteLine($"all calc end. sum : {sum}");
//        }

//        static async Task<int> LongCalc2(int times)
//        {
//            int result = 0;
//            for (int i = 1; i <= times; i++)
//            {
//                result += i;
//                await Task.Delay(100);
//            }

//            return result;
//        }
//    }
//}
