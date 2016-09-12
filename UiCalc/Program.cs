using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace UiCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu
            string op = "";
            do
            {
                Console.Clear();
                PrintMenu();
                
                op = Console.ReadLine();
                Console.Clear();
                int[] valuesForOperations;

                switch(op)
                {
                    case "1":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Add(valuesForOperations[0], valuesForOperations[1]), valuesForOperations, "+");
                        break;
                    case "2":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Subtract(valuesForOperations[0], valuesForOperations[1]), valuesForOperations, "-");
                        break;
                    case "3":
                        valuesForOperations = AskNumbers(AskAmountOfOperationNumbers());
                        ShowResult(Calculator.Sum(valuesForOperations), valuesForOperations, "+");
                        break;
                    case "4":
                        valuesForOperations = AskNumbers(AskAmountOfOperationNumbers());
                        ShowResult(Calculator.Multiply(valuesForOperations), valuesForOperations, "*");
                        break;
                    case "5":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Power(valuesForOperations[0], valuesForOperations[1]), valuesForOperations, "power");
                        break;
                    case "6":
                        valuesForOperations = AskNumbers(1);
                        ShowResult(Calculator.Factorial(valuesForOperations[0]),valuesForOperations,"factorial");
                        break;
                    case "7":
                        break;
                    default:Console.Clear();
                        Console.WriteLine("That is not a valid option, please introduce another one.");
                        Console.ReadLine();
                        break;
                }
            }
            while (op != "7");
            Console.Clear();
            Console.WriteLine("Thanks for using the calculator!");
            Console.ReadKey();
        }

        static void ShowResult(int res, int[] numbers, string operationType)
        {
            Console.Clear();
            Console.WriteLine(ConstructExpression(numbers,operationType) + " = " + res);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }


        static int AskAmountOfOperationNumbers()
        {
            int amount;
            Console.Clear();
            Console.WriteLine("How many number do you which to introduce in this operation?");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return amount;
        }
        static int[] AskNumbers(int howManyNumbers)
        {
            int[] numbers;
            numbers = new int[howManyNumbers];
            
            for(int i = 0; i<howManyNumbers; i++)
            {
                Console.WriteLine("Please insert number " + (i+1) + ":");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            return numbers;
        }

        static string ConstructExpression(int[] numbers, string typeOfOp)
        {
            string operation = "";

            switch (typeOfOp)
            {
                case "power":
                    operation = numbers[0].ToString() + "^" + numbers[1].ToString();
                    break;
                case "factorial":
                    operation = numbers[0].ToString() + "!";
                    break;
                default:
                    operation = numbers[0].ToString();
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        operation += " " + typeOfOp + " " + numbers[i].ToString();
                    }
                    break;
            }
            
            return operation;
        }

        static void PrintMenu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("***********   UiCALC V0.1   ***********");
            Console.WriteLine("***************************************");
            Console.WriteLine("*********** 1 - Add         ***********");
            Console.WriteLine("*********** 2 - Subtract    ***********");
            Console.WriteLine("*********** 3 - Sum         ***********");
            Console.WriteLine("*********** 4 - Multiply    ***********");
            Console.WriteLine("*********** 5 - Power       ***********");
            Console.WriteLine("*********** 6 - Factorial   ***********");
            Console.WriteLine("*********** 7 - EXIT        ***********");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.Write("Please choose an option: ");
        }
    }
}
