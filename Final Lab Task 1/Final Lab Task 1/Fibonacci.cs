using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task_1
{
    class Fibonacci
    {
        public int Fib(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0;    
            if (n == 1) return 1;    


            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        public  void Fshow(int n)
        { 
            Console.Write("Fibonacci Series of " + n + " is:");
            for (int i = 0; i < n; i++)
            {
                Console.Write( "{0} ", Fib(i));
            }
        }
    }
}
