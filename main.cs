using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine(factorial(5));
  }

  public static int factorial(int number)
  {
    int factorialNumber = number;
    int incrementNumber = 1;
    while(number > incrementNumber)
    {
      factorialNumber = factorialNumber * incrementNumber;
      incrementNumber ++;
      
    }

      return factorialNumber;
  }
}