using System;

namespace MyApplication
{
    class Interpolation
    {
        static void Main(string[] args)
        {
            // apply interpolation method
            string fname=" Nabinur ";
            string lname="Islam";

            string concat= $"My name is :{fname}{lname}";
            Console.WriteLine(concat);
        }
    }
}