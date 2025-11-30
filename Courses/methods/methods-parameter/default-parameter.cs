using System;

namespace MyApplication
{
    class Default_parameter
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }

        // Sweden
        // India
        // Norway
        // USA
    }
}