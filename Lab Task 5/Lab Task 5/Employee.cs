using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Employee:Person 
    {
        private string name;
        private string dob;
        private Account acc;

        public Employee() {}
            
        public Employee(string name, string dob, Account acc)
        {
            this.name = name;
            this.dob = dob;
            this.acc = acc;
        }
        public void setAcc(Account acc)
        {
            Console.WriteLine("New Employee Account Set");
        }
        public void display()
        {
            Console.WriteLine("Employee Name:" + name);
            Console.WriteLine("Employee D O B:" + dob);
        }
    }
}
