using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Input Number One");
    double numOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input Number Two");
    double numTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Operation?");
    string operation = Console.ReadLine();
  
    if (operation == "addition") {
      Console.WriteLine(numOne + numTwo + $" is the sum of {numOne} and {numTwo}");
    } else if (operation == "subtraction") {
      Console.WriteLine(numOne - numTwo + $" is the difference of {numOne} and {numTwo}");
    } else if (operation == "multiplication") {
      Console.WriteLine(numOne * numTwo + $" is the answer to {numOne} multiplied by {numTwo}");
    } else if (operation == "division") {
      Console.WriteLine(numOne/numTwo + $" is the answer to {numOne} divided by {numTwo}");
    }
  }
  }
