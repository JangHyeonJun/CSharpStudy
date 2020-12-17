using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Study_Bitvector32
    {
        static void Main()
        {
            Console.WriteLine("WrongCase 1");
            WrongCase1();
            Console.WriteLine();
            Console.WriteLine("WrongCase 2");
            WrongCase2();
        }

        static void WrongCase1()
        {
            BitVector32 bv = new BitVector32(0);

            var section1 = BitVector32.CreateSection(10);
            var section2 = BitVector32.CreateSection(10, section1);
            var section3 = BitVector32.CreateSection(10, section2);
            var section4 = BitVector32.CreateSection(10, section2);

            bv[section1] = 1;
            bv[section2] = 2;
            bv[section3] = 3;
            bv[section4] = 4;

            Console.WriteLine(bv[section1]);
            Console.WriteLine(bv[section2]);
            Console.WriteLine(bv[section3]);
            Console.WriteLine(bv[section4]);
        }

        static void WrongCase2()
        {
            BitVector32 bv = new BitVector32(0);

            var section1 = BitVector32.CreateSection(1);
            var section2 = BitVector32.CreateSection(2, section1);
            var section3 = BitVector32.CreateSection(3, section2);
            var section4 = BitVector32.CreateSection(4, section3);

            bv[section1] = 2;
            bv[section2] = 3;
            bv[section3] = 4;
            bv[section4] = 5;

            Console.WriteLine(bv[section1]);
            Console.WriteLine(bv[section2]);
            Console.WriteLine(bv[section3]);
            Console.WriteLine(bv[section4]);
        }
    }
}
