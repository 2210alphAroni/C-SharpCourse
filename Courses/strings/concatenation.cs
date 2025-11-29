using System;

namespace MyApplication
{
    class Concatenation
    {
        static void Main(string[] args)
        {
            // basic concat apply

            // string fname="Nabinur ";
            // string lname="Islam";

            // string concat= fname+lname;
            // Console.WriteLine(concat);

            // concat method apply
            string fname="Nabinur ";
            string lname="Islam";

            string concat= string.Concat(fname,lname);
            Console.WriteLine(concat);
        }

    }
}