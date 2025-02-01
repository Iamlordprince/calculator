using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            string answer;
            Console.WriteLine("hello Welcome to calculator program!");
            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what type operation would you like to perform");
            Console.WriteLine("please enter + for addition");
            Console.WriteLine("please enter - for subtraction");
            Console.WriteLine("please enter * for multiplication");
            Console.WriteLine("please enter / for division");
            answer = Console.ReadLine();

            if(answer == "+")
            {
                result = num1 + num2;
            }else if(answer == "-")
            {
                result = num1 - num2;
            }else if(answer == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("the result is " + result);
            Console.WriteLine("thank you");

            Console.ReadKey();
        }
    }
}
