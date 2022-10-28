using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the Circle:");
            double r = double.Parse(Console.ReadLine());
            double A = (3.14) * r * r;
            Console.WriteLine("The Area of the circle is=" + A);
        }
    }
}
