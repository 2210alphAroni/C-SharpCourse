using System;

namespace MyApplication
{
    class Return_value
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3,6));  //i can use variable to declare the methods calls
        }

    }
}