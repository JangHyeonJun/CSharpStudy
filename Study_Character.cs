//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace CSharpStudy
//{
//    class Study_Character
//    {
//        private static void Main(string[] args)
//        {
//            Console.WriteLine(Char.GetUnicodeCategory('ㅎ').ToString());
//            Console.WriteLine(Char.IsDigit('2'));
//            Console.WriteLine(Char.Parse("ㅎ"));
//            Console.WriteLine((int)'5');
//            Console.WriteLine(((IConvertible)('3')).ToInt32(null));
//            String s = "Hi there"; // CLR에서 IL명령어를 통해 리터럴을 그대로 string 객체로 생성
//            string s2 = new string("abc".ToCharArray()); // 어차피 "abc" 라는 string 객체를 만들게 됨으로 불필요한 작업이 있는 코드
//            string path1 = "C:\\Windows\\System32\\Notepad.exe";
//            string path2 = @"C:\Windows\System32\Notepad.exe"; // 축자 문자열 지시 기호(@) 사용시 모든 문자를 문자열로 간주

//            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
//            Console.WriteLine(Thread.CurrentThread.CurrentUICulture);
//        }
//    }
//}
