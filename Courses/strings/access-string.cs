using System;

namespace MyApplication
{
    class AccessStrings
    {
        static void Main(string[] args)
        {
            string fname="Nabinur";
            Console.WriteLine(fname[0]);
            Console.WriteLine(fname[4]);
            Console.WriteLine(fname.IndexOf("b"));



            // location specifically from the string using substring method

            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}