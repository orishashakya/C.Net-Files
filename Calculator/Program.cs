using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;

            int result = 0;

            Console.WriteLine("Hello!Welcome to the Calculator program.");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");

            answer = Console.ReadLine();

            bool validOperation = true;

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s") 
            {
                 result =num1 - num2;
            }
            else if( answer == "m") 
            {
                 result=num1 * num2;
            }
            else if(answer =="d")
            {
                if (num2 != 0)
                {
                    result = num1/num2;
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed!");
                    validOperation = false;

                }
            }
            else
            {
                Console.WriteLine("Invalid operation entered. Please enter a, s, m, or d.");
                validOperation = false;

            }
            if (validOperation)
            {
                Console.WriteLine($"The result is: {result}");
            }

        
                Console.WriteLine("Thank you for using the calculator program!");
                Console.ReadKey();
        }
    }
}
