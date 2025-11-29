using System;

namespace MyApplication
{
    class SpecialCharacter
    {
        static void Main(string[] args)
        {
            // escape character  like \' , \" & \\
            string opp="my name is \'MR.\' Roni";  // can be possible with single quote & double quote
            Console.WriteLine(opp);



            // use \\
            string a="ygwdtyefw \\isvgh hduiwefd";
            Console.WriteLine(a);

            // use \n , \t and \b
            string k="kobutor \nkhan";
            Console.WriteLine(k);

            string p="potash \tmiya";
            Console.WriteLine(p);


            string t="target \b you";  // \b you & \byou both work 
            Console.WriteLine(t);
        }
    }
}