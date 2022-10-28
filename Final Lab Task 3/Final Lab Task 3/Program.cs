using System;

namespace Final_Lab_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BC bcal = new BC();
            SC scal = new SC();

            Console.WriteLine("***Basic Calculator***");
            Console.WriteLine();

            Console.WriteLine("...Addition...");
            bcal.sum(69,1);
            bcal.displayResult();
            Console.WriteLine();

            Console.WriteLine("...Subtraction...");
            bcal.sub(69,1);
            bcal.displayResult();
            Console.WriteLine();

            Console.WriteLine("...Multiplication...");
            bcal.multiplication(69,0);
            bcal.displayResult();
            Console.WriteLine();

            Console.WriteLine("...Division...");
            bcal.division(69,0);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***Scientific Calculator***");
            Console.WriteLine();

            Console.WriteLine("...X to Y...");
            Console.WriteLine();
            scal.XtoY(69,1);

            Console.WriteLine("...Square...");
            scal.square(4761);
            scal.displayResult();
            Console.WriteLine();

            Console.WriteLine("Factorial");
            scal.factorial(69);
        }
    }
}
