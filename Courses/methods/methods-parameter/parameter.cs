using System;

namespace MyApplication
{
    // class Parameter
    // {
    //     static void MyMethod(string fname)
    //     {
    //         Console.WriteLine(fname + " Refsnes");
    //     }

    //     static void Main(string[] args)
    //     {
    //         MyMethod("Liam");
    //         MyMethod("Jenny");
    //         MyMethod("Anja");
    //     }

    //     // Liam Refsnes
    //     // Jenny Refsnes
    //     // Anja Refsnes
    // }


    class Parameter2
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }

        // Liam is 5
        // Jenny is 8
        // Anja is 31
    }
}