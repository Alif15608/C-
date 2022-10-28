using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_3
{
    class BC:Basic_Calculator
    {
        int result = 0;
        public int sum(int number1, int number2)
        {
            Console.WriteLine("Number 1: " + number1 + " Number 2: " + number2);
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            Console.WriteLine("Number 1: " + number1 + " Number 2: " + number2);
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            Console.WriteLine("Number 1: " + number1 + " Number 2: " + number2);
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            Console.WriteLine("Number 1: " + number1 + " Number 2: " + number2);
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine("Result: " + result);
                return 0;
            }
            else
            {
                Console.WriteLine("Divide by zero error");
                return 0;
            }

            return result;
        }
        public void displayResult()
        {
            Console.WriteLine("Result: " + result);
        }
    }
}
