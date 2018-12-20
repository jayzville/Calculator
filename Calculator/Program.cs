using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            var calculatorInstance = new Calculator();

            Console.Write("Welcome to the 5 Operation Calculator\n");

            while (calculatorInstance.UsingCalc) {
                var a = calculatorInstance.ValueInMemory.ToString();
                if (calculatorInstance.ContinueOperation == 1) {
                    Console.Write("Please enter the first argument: ");
                    a = Console.ReadLine();
                }
                else {
                    Console.Write("Current Value in memory is: " + a + "\n");
                }

                Console.Write("Please enter the second argument: ");
                var b = Console.ReadLine();

                if (decimal.TryParse(a, out var aParsed) && decimal.TryParse(b, out var bParsed)) {
                    Console.Write("Please enter the operation you which to perform: ");
                    var operation = Console.ReadLine();

                    switch (operation) {
                        case "+":
                            calculatorInstance.ValueInMemory = calculatorInstance.Add(aParsed, bParsed);
                            break;

                        case "-":
                            calculatorInstance.ValueInMemory = calculatorInstance.Subtract(aParsed, bParsed);
                            break;

                        case "*":
                        case "x":
                            calculatorInstance.ValueInMemory = calculatorInstance.Multiply(aParsed, bParsed);
                            break;

                        case "/":
                            if (bParsed == 0) {
                                Console.WriteLine("The result will be undefined, please do not enter 0 as your divisor");
                                continue;
                            }
                            calculatorInstance.ValueInMemory = calculatorInstance.Divide(aParsed, bParsed);
                            break;
                        case "^":
                            calculatorInstance.ValueInMemory = calculatorInstance.Exponential(aParsed, bParsed);
                            break;

                        default:
                            Console.WriteLine("Not a valid operation");
                            break;
                    }

                    Console.WriteLine("Your answer is: " + calculatorInstance.ValueInMemory);
                    Console.WriteLine("\nWould you like to continue with this operation or start a new one?\nType 'cont' to continue or 'cl' to clear current operation\nType anything else to exit.");
                    var userResponse = Console.ReadLine();

                    switch (userResponse) {
                        case "cont":
                        case "continue":
                            calculatorInstance.ContinueOperation++;
                            break;

                        case "clear":
                        case "cl":
                            calculatorInstance.ValueInMemory = 0;
                            calculatorInstance.ContinueOperation = 1;
                            break;

                        default:
                            calculatorInstance.UsingCalc = false;
                            Console.WriteLine("Thanks for using the Calculator!");
                            Console.ReadKey();
                            return;
                    }
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine("Invalid numbers entered");
                    Console.ReadKey();
                }
            }
        }
    }
}
