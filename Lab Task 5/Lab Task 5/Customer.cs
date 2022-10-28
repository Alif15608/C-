using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Customer:Person
    {
        private string name;
        private string dob;
        private Account acc;

        public Customer() { }

        public Customer(string name, string dob, Account acc)
        {
            this.name = name;
            this.dob = dob;
            this.acc = acc;
        }

        public void setAcc(Account acc)
        {
            Console.WriteLine("New Customer Account Set");
        }
        public void display()
        {
            Console.WriteLine("Customer Name:" + name);
            Console.WriteLine("Customer D O B:" + dob);
        }
    }
}
