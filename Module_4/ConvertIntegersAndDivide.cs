using System;

class Program2 
{
  static void Main (string[] args) 
  {
    Console.WriteLine("Enter the first number: ");
    string input1 = Console.ReadLine();

    Console.WriteLine("Enter the second number: ");
    string input2 = Console.ReadLine();

    int number1 =  Convert.ToInt32(input1);
    int number2 = Convert.ToInt32(input2);

    int result = Divide(number1, number2);
    Console.WriteLine($"The result of dividing {number1} and {number2} is {result}");
  }

  static int Divide(int a, int b)
  {
    return a / b;
  }
}
