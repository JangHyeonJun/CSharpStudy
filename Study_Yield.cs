//using System;
//using System.Collections.Generic;

//class Program
//{
//    static IEnumerable<int> GetNumber()
//    {
//        yield return 10;  // 첫번째 루프에서 리턴되는 값
//        yield return 20;  // 두번째 루프에서 리턴되는 값
//        yield return 30;  // 세번째 루프에서 리턴되는 값
//    }

//    static IEnumerable<int> GetNumberInArr()
//    {
//        int[] arr = new int[3] { 9, 2, 3 };
//        for (int i = 0; i < arr.Length; i++)
//        {
//            yield return arr[i];
//        }
//    }

//    static void Main(string[] args)
//    {
//        int n = 1;
        
//        if (n is int nn)
//            Console.WriteLine(nn);

//    }
//}