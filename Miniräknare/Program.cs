using System;

namespace Miniräknare
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool isFinished = false;


            while (isFinished == false)
            {
                Console.WriteLine(
                        "1.Add two numbers\n" +
                        "2.Multiply two numbers\n" +
                        "3.Sum the numbers between two numbers.\n" +
                        "4.Add number to memory\n" +
                        "5.Clear memory\n" +
                        "6.Print calculator contents.\n" +
                        "7.Quit");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter two numbers");
                        calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                        calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Total sum is: {calc.SumNumbers()}");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter two numbers");
                        calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                        calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Total sum is: {calc.MultiplyNumbers()}");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter two numbers");
                        calc.FirstNumber = Convert.ToInt32(Console.ReadLine());
                        calc.SecondNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Total numbers between {calc.FirstNumber} and {calc.SecondNumber} is: {calc.SumInBetween()}");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter the number you want to save in memory");
                        calc.NumberInMemory = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Number successfully added to memory {calc.NumberInMemory} ");
                        break;
                    case "5":
                        Console.Clear();
                        calc.NumberInMemory = 0;
                        Console.WriteLine("Number in memory cleared");
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine($"Current number in memory: {calc.NumberInMemory}");
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Only numbers are allowed");
                        break;
                }
            }
        }
    }
}
