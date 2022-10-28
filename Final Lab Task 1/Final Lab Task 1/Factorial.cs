using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1
{
    class Factorial
    {
            int i, fact = 1;

        public void fShow(int n)
        {
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + n + " is: " + fact);
        }
            
    }
}
