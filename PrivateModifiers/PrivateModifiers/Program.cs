using System;

namespace PrivateModifiers
{
/*    class Test
    {
        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }
    }*/
    class Program
    {
        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }
        }
        public void TestMethod()
        {
            Program.Main(new string[] { "" });
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
