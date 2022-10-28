using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public string Name
        {
            get { return accName; }
            set { accName = value; }
        }
        
        public string AcID
        {
            get { return acid; }
            set { acid = value; }
        }
        
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }
        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance = balance+amount;
            Console.WriteLine("New Balance after Deposit             :" + balance);
        }
        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                balance = balance-amount;
                Console.WriteLine("New Balance after Withdraw            :" + balance);
            }
            else
                Console.WriteLine("Insufficient Balance");
        }
        public void Transfer(int amount, string Accountreceiver)
        {
            if (amount < balance)
            {
                balance = balance-amount;
                Console.WriteLine(amount + " TK Transfer to the Receiver Name : " + Accountreceiver);
                Console.WriteLine("Current Balance                       :" + balance);
            }
            else
                Console.WriteLine("Insufficient Balance");

        }

        public void Show()
        {
            Console.WriteLine("Account Name                          : " + accName);
            Console.WriteLine("Account ID                            : " + acid);
            Console.WriteLine("Balance                               : " + balance);
        }

    }
}
