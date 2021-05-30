//using System;
//using System.Collections.Generic;

//namespace CSharpStudy
//{
//    class Character
//    {
//        // 컬렉션에 할당을 하는 방식보다는 멤버 초기화 구문이 좋다.
//        // 여러 버전의 생성자를 추가하든 상관없이 멤버 변수를 올바르게 초기화할 수 있다.
//        // 만약 상속을 받고있는 클래스의 경우 멤버 초기화가 생성자 보다 빨리 진행되며, 멤버 초기화 순서는 선언 순서와 같다.
//        // 단 0 또는 null로 초기화할 경우에는 멤버 초기화가 필요하지 않다. CLI에서는 CPU 명령을 통해 저수준에서 메모리 블록을 0으로 설정해주기 때문에.
//        // 가끔 할당 구문이 필요한 경우가 있다(초기화가 여러방식으로 이루어질 경우, 초기화 과정에서 예외가 발생할 수 있을 경우)
//        // 멤버 초기화와 할당 구문을 중복해서 사용하는 경우를 줄여야한다.
//        private List<string> friendsList = new List<string>(); 


//        // C#에서 소멸자(finalizer)를 사용하는 것은 좋지 못하다. (비관리 리소스를 사용하는 경우엔 반드시 사용해야한다. 사용자가 IDispose를 제대로 구현 안했을 수도..)
//        // 소멸자의 호출 시기가 명확하지 않고, 이로 인해 가비지 컬렉션이 즉각적으로 이루어지지 않아 성능에 문제가 될 수 있다.
//        // 기본적으로 GC에서 메모리를 관리해준다. 만약 직접 해제해야되는 리소스가 있다면 소멸자 대신 IDispose 인터페이스를 사용해라.
//        // 소멸자를 거치고나면 객체가 도달가능해도 가비지로 간주해 정리해버린다. 그러므로 소멸자에서 리소스 해제 외에 다른 짓은 하지 말아라.
//        ~Character() { }
//    }
//    public enum ECharacterType
//    {
//        NPC = 0,
//        PC,
//        MONSTER
//    }


//    class EffectiveCSharp_1
//    {
//        public static void Main()
//        {
//            var myCharType = ECharacterType.PC;

//            Console.WriteLine($"ECharacterType: Invalid");
//            Console.WriteLine($"ECharacterType.PC: {ECharacterType.PC}");
//            Console.WriteLine($"MyCharType: {myCharType}\n\n");

//            Console.WriteLine("Use nameof()");
//            Console.WriteLine($"ECharacterType: {nameof(ECharacterType)}");
//            Console.WriteLine($"ECharacterType.PC: {nameof(ECharacterType.PC)}");
//            Console.WriteLine($"MyCharType: {nameof(myCharType)}");
//        }
//    }
//}
