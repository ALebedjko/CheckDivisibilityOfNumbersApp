using System;

namespace CheckDivisibilityOfNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Check divisibility of numbers";

            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                Console.WriteLine("Please enter integer number");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Empty value provided, please enter integer number");
                    userInput = Console.ReadLine();
                }

                bool isNumeric = int.TryParse(userInput, out var inputNumber);

                if (isNumeric)
                {
                    isUserInputValid = true;
                    DivisibleByNumber divisibleByThree = new DivisibleByThree();

                    Console.WriteLine(divisibleByThree.isDivisible(inputNumber)
                        ? $"Number {inputNumber} is divisible by {DivisibleByThree.DIVIDER}"
                        : $"Number {inputNumber} is not divisible by {DivisibleByThree.DIVIDER}");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
                
                Console.WriteLine("Try another one? y/n");
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    isUserInputValid = false;
                    Console.WriteLine("");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("Have a nice day!");
        }
    }
}