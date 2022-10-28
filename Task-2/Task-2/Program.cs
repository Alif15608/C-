using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Root");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st input");
            double input_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd input");
            double input_2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                case 5:
                    {
                        result = Root(input_1, input_2);
                        break;
                    }
           
                default:
                    Console.WriteLine("Incorrect Command");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
        //Addition
        public static double Addition(double input_1, double input_2)
        {
            double result = input_1 + input_2;
            return result;
        }

        //Subtration
        public static double Subtraction(double input_1, double input_2)
        {
            double result = input_1 - input_2;
            return result;
        }

        //Multiplication
        public static double Multiplication(double input_1, double input_2)
        {
           double result = input_1 * input_2;
            return result;
        }

        //Division
        public static double Division(double input_1, double input_2)
        {
            double result = input_1 / input_2;
            return result;
        }

        //Root
        public static double Root(double input_1, double input_2)
        {
            //double result;
            Console.WriteLine("Find Root for input:");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                    return result;
        }

    }
}