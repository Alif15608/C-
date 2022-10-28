using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Account
    {
        public int account_id;
        public double amount;
        public string accType;

        public Account(int account_id, double amount, string accType)
        {
            this.account_id = account_id;
            this.amount = amount;
            this.accType = accType;
        }
    }
}
