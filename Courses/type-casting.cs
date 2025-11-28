using System;

namespace MyApplication
{
  class Type_Casting
  {
    static void Main(string[] args)
    {
        // Implicit
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);


    //   Explicit
    double mydouble = 9.78;
    int myint = (int) mydouble;    // Manual casting: double to int

    Console.WriteLine(mydouble);   // Outputs 9.78
    Console.WriteLine(myint);      // Outputs 9

     // type conversion methods 
    int num = 10;
    double float_num = 5.25;
    bool logic = true;

    Console.WriteLine(Convert.ToString(num));    // convert int to string
    Console.WriteLine(Convert.ToDouble(num));    // convert int to double
    Console.WriteLine(Convert.ToInt32(float_num));  // convert double to int
    Console.WriteLine(Convert.ToString(logic));   // convert bool to string
    }
  }
}