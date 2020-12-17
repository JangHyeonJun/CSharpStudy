//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpStudy
//{
//    class Base<T>
//    {
//        public virtual void Test<A>(int num) { }
//        //public virtual void Test<A>(int num) where A : ICollection<A> { }
//        public virtual void Test<A>(int num, int num2) { }
//        public virtual void Test<A,B>(int num) { }

//    }
//    class Derived<R> : Base<R>
//    {
//        // 오버라이딩 시에는 타입 매개변수의 갯수(이름은 달라도 됨)와 제약 조건등이 일치해야 한다.
//        //public override void Test<A>(int value) where A : int
//        //{
//        //    base.Test<A>();
//        //}
//        public override void Test<A>(int value) 
//        {
//            base.Test<A>(value);
//        }
//    }
//    class Study_Generic
//    {
//        private static void Main(string[] args)
//        {

//        }
//    }
//}
