using System;
using System.Threading.Tasks;
using System.Threading;
namespace CSharpStudy
{
    class Study_Async_2
    {
        private static void Main(string[] args)
        {
            TestTask4();
        }

        private static void TestTask1()
        {
            Console.WriteLine("Main Start");
            var task = Task1();
            task.Start();
            Console.WriteLine("Waiting Task...");

            Console.WriteLine($"Sum = {task.Result}");
        }

        private static void TestTask2()
        {
            Console.WriteLine("Main Start");
            var task = Task2();
            Console.WriteLine("Waiting Task...");

            Console.WriteLine($"Sum = {task.Result}");
        }

        private static void TestTask3()
        {
            Console.WriteLine("Main Start");
            var task = Task3();
            Console.WriteLine("Waiting Task...");

            Console.WriteLine($"Sum = {task.Result}");
        }

        private static void TestTask4()
        {
            Console.WriteLine("Main Start");
            var task = Task4();
            Console.WriteLine("Waiting Task...");

            Console.WriteLine($"Sum = {task.Result}");
        }

        private static Task<int> Task1()
        {
            Console.WriteLine("Task Start");
            var task = new Task<int>(() =>
            {
                int sum = 0;
                for (int i=0; i<10; i++)
                {
                    sum += i;
                    Thread.Sleep(100);
                }
                return sum;
            });
            Console.WriteLine("Task End");

            return task;
        }

        private static async Task<int> Task2()
        {
            Console.WriteLine("Task Start");
            var task = await Task.Run(() =>
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                    Thread.Sleep(100);
                }
                return sum;
            });
            Console.WriteLine("Task End");

            return task;
        }

        private static Task<int> Task3()
        {
            Console.WriteLine("Task Start");
            var task = Task.Run(() =>
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                    Thread.Sleep(100);
                }
                return sum;
            });
            Console.WriteLine("Task End");

            return task;
        }

        private static Task<int> Task4()
        {
            Console.WriteLine("Task Start");
            var task = Task.Run(() =>
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                    Thread.Sleep(100);
                }
                return sum;
            });
            task.Wait();
            Console.WriteLine("Task End");

            return task;
        }
    }
}
