using System;

namespace Final_Lab_Task_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Factorial F = new Factorial();
            F.fShow(6);
            Console.WriteLine();

            Fibonacci f = new Fibonacci();
            f.Fshow(6);
            Console.WriteLine();

            Prime_Number p = new Prime_Number();
            p.pShow(6);
            Console.WriteLine();

            Sum s = new Sum();
            s.show(675);
        }
    }
}
