using System;

namespace InstanceVariables
{
    class Program
    {
        class Product
        {
            public string name;
            public int price;
        }
        static void Main(string[] args)
        {
            /*// 인스턴스를 생성합니다.
            Product product = new Product();

            // 인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");*/
            

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };
        }
    }
}
