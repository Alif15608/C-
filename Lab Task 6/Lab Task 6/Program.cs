using System;

namespace Lab_Task_6
{
    class Program
    {
        public class University
        {
            public void Bsc()
            {
                Console.WriteLine("Bsc Knowledge");
            }
        }
        public class College:University
        {
            public void Class_11()
            {
                Console.WriteLine("Class 11 Knowledge");
            }
            public void Class_12()
            {
                Console.WriteLine("Class 12 Knowledge");
            }
        }
        public class High_School:College
        {
            public void Class_7()
            {
                Console.WriteLine("Class 7 Knowledge");
            }
            public void Class_8()
            {
                Console.WriteLine("Class 8 Knowledge");
            }
            public void Class_9()
            {
                Console.WriteLine("Class 9 Knowledge");
            }
            public void Class_10()
            {
                Console.WriteLine("Class 10 Knowledge");
            }
        }
        public class Middle_School:High_School
        {
            public void Class_4()
            {
                Console.WriteLine("Class 4 Knowledge");
            }
            public void Class_5()
            {
                Console.WriteLine("Class 5 Knowledge");
            }
            public void Class_6()
            {
                Console.WriteLine("Class 6 Knowledge");
            }
        }
        public class Primary_School:Middle_School
        {
            public void Class_1()
            {
                Console.WriteLine("Class 1 Knowledge");
            }
            public void Class_2()
            {
                Console.WriteLine("Class 2 Knowledge");
            }
            public void Class_3()
            {
                Console.WriteLine("Class 3 Knowledge");
            }
        }
        static void Main(string[] args)
        {
            Primary_School pm = new Primary_School();
            pm.Bsc();
        }
    }
}
