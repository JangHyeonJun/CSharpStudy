using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{

        class Study08
    {
        static void Main(string[] args)
        {
            student kim = new student();

            kim.name = "김씨";
            kim.age = 17;

            student lee = new student();
            lee.name = "이씨";
            lee.age = kim.age;

            Console.WriteLine("이름은 {0}이고 나이는 {1}입니다.", kim.name, kim.age);
            Console.WriteLine("이름은 {0}이고 나이는 {1}입니다.", lee.name, lee.age);
        }
    }

    class student
    {
        public string name;
        public int age;
    }

}
