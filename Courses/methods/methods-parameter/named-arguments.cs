using System;

namespace MyApplication
{

    class Named_Arguments
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            MyMethod(child3: "John", child1: "Liam", child2: "Liam");   // follow the key:value pair syntax
        }

        // The youngest child is: John
    }
}