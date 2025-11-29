using System;

namespace MyApplication
{
  class Boolean_Example
  {
    static void Main(string[] args)
    {
      int myAge = 25;
      int votingAge = 18;
      Console.WriteLine(myAge >= votingAge);  // returns True, meaning 25 year olds are allowed to vote!
    }
  }
}