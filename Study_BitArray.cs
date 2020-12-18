using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Study_BitArray
    {
        static void Main()
        {
            InitializeBitArray2();
        }

        static void InitializeBitArray()
        {
            int n = 5;
            BitArray ba = new BitArray(new int[] { n });
            foreach (var a in ba)
            {
                Console.Write($"{a} ");
                Console.Write($"{a} ");
            }
        }

        static void InitializeBitArray2()
        {

            int n = 3;
            BitArray ba = new BitArray(new byte[] { (byte)n });

            Console.WriteLine("ba.Length = default");
            foreach (var a in ba)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine();
            Console.WriteLine("ba.Length = 4");

            ba.Length = 4;
            foreach (var a in ba)
            {
                Console.Write($"{a} ");
            }


            Console.WriteLine();
            Console.WriteLine($"ba[0] = {ba[0]}, ba[1] = {ba[1]}, ba[2] = {ba[2]}");
        }
    }
}
