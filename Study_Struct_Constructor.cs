//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    internal struct SomeValType
//    {
//        public Int32 m_x; // = 5 ; 인라인 초기화 식을 작성할 수 없다.
//        public static Int32 m_y = 10; // 정적 변수의 인라인 초기화 식은 가능하다.
//        public const Int32 m_z = 0; // 상수 또한 가능하다.
//        public Int32 num;
//    }
//    internal sealed class SomeType
//    {
//        public const SomeType empty = null;
//    }

//    class Base { }
//    class Derived : Base { }

//    class Study_Struct_Constructor
//    {
//        private static void Main(string[] args)
//        {
//            SomeValType sv = new SomeValType();
//            sv.num = 999;
//            Console.WriteLine($"[{sv.m_x},{SomeValType.m_y},{SomeValType.m_z}] : {sv.num}");

//            Derived d = new Derived();
//            Base b = d;
//            Console.WriteLine(d);
//            Console.WriteLine(typeof(Derived));
//            Console.WriteLine(b);
//            Console.WriteLine(b.GetType());
//        }
//    }
//}
