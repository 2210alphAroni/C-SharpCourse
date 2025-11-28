using System;

namespace MyApplication
{
    class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value1");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value2:");
            int b=Convert.ToInt32(Console.ReadLine());

            int add=a+b;
            int sub=a-b;
            int mul=a*b;
            double div=Convert.ToDouble(a/b);
            int mod=a%b;

            Console.WriteLine("Addition:" +add);
            Console.WriteLine("Substraction:" +sub);
            Console.WriteLine("Multiplication:" +mul);
            Console.WriteLine("Division:" +div);
            Console.WriteLine("Modolous:" +mod);
        }
    }
}