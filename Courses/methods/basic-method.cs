using System;

namespace MyApplication
{
    class Basic_Methods
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod(); //one time call
            // multiple time call
            MyMethod();
            MyMethod();
        }
    }
}