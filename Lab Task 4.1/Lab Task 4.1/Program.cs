using System;

namespace Lab_Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3] { { 5, 6, 7 }, { 1, 2, 3 }, { 4, 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                    Console.WriteLine(array[i,j]);
            }
        }
    }
}
