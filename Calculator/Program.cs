using System;
using System.Linq;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            var calculatorInstance = new Calculator();
            var notDone = true;
            var iteration = 1;
            var result = calculatorInstance.ValueInMemory;

            Console.Write("Welcome to the 5 Operation Calculator\n");

            while (notDone) {

                // There must be a better way to do this bit
                var a = calculatorInstance.ValueInMemory.ToString();
                //If first operation ever
                if (iteration == 1) {
                    Console.Write("Please enter the first argument: ");
                     a = Console.ReadLine();
                }
                else {
                    Console.Write("Current Value in memory is: " + a + "\n");
                }

                Console.Write("Please enter the second argument: ");
                var b = Console.ReadLine();

                // a here is a string - it must be passed as a string for this check to work 
                // Check the inputs are valid - should only be a number here - convert only if digits
                if (decimal.TryParse(a, out var aParsed) && decimal.TryParse(b, out var bParsed)) {

                    // Take in the operation to perform. - should only allow +, -, x, /
                    Console.Write("Please enter the operation you which to perform: ");
                    var operation = Console.ReadLine();

                    switch (operation) {
                        case "+":
                            result = calculatorInstance.Addition(aParsed, bParsed);
                            break;

                        case "-":
                            result = calculatorInstance.Subtract(aParsed, bParsed);
                            break;

                        case "*":
                        case "x":
                            result = calculatorInstance.Multiply(aParsed, bParsed);
                            break;

                        case "/":
                            result = calculatorInstance.Divide(aParsed, bParsed);
                            break;
                        case "^":
                            result = calculatorInstance.Exponential(aParsed, bParsed);
                            break;

                        default:
                            Console.WriteLine("Not a valid operation");
                            break;
                    }

                    Console.WriteLine("Your answer is: " + result);

                    Console.WriteLine("Would you like to continue with this operation or start a new one?");
                    var userResponse = Console.ReadLine();

                    switch (userResponse) {
                        case "yes":
                        case "y":
                            calculatorInstance.ValueInMemory = result;
                            iteration++;
                            break;

                        case "clear":
                        case "cl":
                            calculatorInstance.ValueInMemory = 0;
                            iteration = 1;
                            break;

                        default:
                            notDone = false;
                            Console.WriteLine("The End");
                            Console.ReadKey();
                            break;
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
