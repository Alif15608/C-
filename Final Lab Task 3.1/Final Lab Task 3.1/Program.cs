using System;

namespace Final_Lab_Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankingAccount acc1 = new BankingAccount("Alif", "Current",10000);
            BankingAccount acc2 = new BankingAccount("Ahad", "Savings",5000);
            BankingAccount acc3 = new BankingAccount("Raja", "Overdraft",2000);

            Console.WriteLine("***Accounts Created Successfully***");
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);

            if (acc1.deposit(270))
            {
                Console.WriteLine("***Deposit Successful***");
                Console.WriteLine(acc1);
            };


            if (!acc2.withdraw(2000))
            {
                Console.WriteLine("80% Balance can be able to withdraw");
                Console.WriteLine(acc2);
            }
            if (acc3.withdraw(1000))
            {
                Console.WriteLine("Succesfully withdraw extra amount from overdraft");
                Console.WriteLine(acc3);
            }

            acc2.setAccountType("Overdraft");
            acc1.setAccountType("Savings");

            Console.WriteLine("---Accounts After Modification---");
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
            Console.WriteLine(acc3);
        }
    }
}
