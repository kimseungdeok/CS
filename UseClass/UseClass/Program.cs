using System;
using System.Collections.Generic;

namespace UseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random 클래스
            /*Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());*/

            // List 클래스
                // 기존 배열 생성 코드 
            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            /*List<int> list = new List<int>();
            list.Add(54);
            list.Add(154);
            list.Add(41);
            list.Add(574);

            foreach(var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }
            */
            // 참고 : List 인스턴스 생성과 동시에 요소 추가
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            list.Remove(52);

            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
            }

        }
    }
}
