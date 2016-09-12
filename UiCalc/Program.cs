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
                Console.WriteLine("1 - Add \n2 - Subtract \n3 - Sum \n4 - Multiply \n5 - Power \n6 - Factorial \n7 - EXIT");
                Console.WriteLine("Please choose an option: ");
                op = Console.ReadLine();
                Console.Clear();
                int[] valuesForOperations;

                switch(op)
                {
                    case "1":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Add(valuesForOperations[0], valuesForOperations[1]));
                        break;
                    case "2":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Subtract(valuesForOperations[0], valuesForOperations[1]));
                        break;
                    case "3":
                        valuesForOperations = AskNumbers(AskAmountOfOperationNumbers());
                        ShowResult(Calculator.Sum(valuesForOperations));
                        break;
                    case "4":
                        valuesForOperations = AskNumbers(AskAmountOfOperationNumbers());
                        ShowResult(Calculator.Multiply(valuesForOperations));
                        break;
                    case "5":
                        valuesForOperations = AskNumbers(2);
                        ShowResult(Calculator.Power(valuesForOperations[0], valuesForOperations[1]));
                        break;
                    case "6":
                        valuesForOperations = AskNumbers(1);
                        ShowResult(Calculator.Factorial(valuesForOperations[0]));
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

        static void ShowResult(int res)
        {
            Console.Clear();
            Console.WriteLine("The result of that operation is: " + res);
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
    }
}
