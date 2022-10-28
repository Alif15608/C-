using System;

namespace LAb_TAsk_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[5] { 5, 4, 3, 2, 1 };

            Array.ForEach(array, i => sum += i);
            Console.WriteLine(sum);
        }
    }
}
