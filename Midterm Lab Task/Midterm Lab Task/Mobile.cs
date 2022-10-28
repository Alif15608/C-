using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Mobile
    {
        private string mobileOwnerName;
        private string mobileNumber;
        private string mobileBalance;
        private string mobileOSName;
        private bool alock;

        public string MobileOwnerName
        {
            get { return mobileOwnerName; }
            set { mobileOwnerName = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public string MobileBalance
        {
            get { return mobileBalance; }
            set { mobileBalance = value; }
        }

        public string MobileOSName
        {
            get { return mobileOSName; }
            set { mobileOSName = value; }
        }

        public bool Lock
        {
            get { return alock; }
            set { alock = value; }
        }

        public Mobile() { }

        public Mobile(String mobileOwnerName, String mobileNumber, String mobileBalance, String mobileOSName, bool alock)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.mobileBalance = mobileBalance;
            this.mobileOSName = mobileOSName;
            this.alock = alock;
        }

        public void showInfo()
        {
            if (alock == false)
            {
                Console.WriteLine("...This Phone is Unlocked...");
                Console.WriteLine(" Mobile owner Name  : " + mobileOwnerName);
                Console.WriteLine(" Mobile Number      : " + mobileNumber);
                Console.WriteLine(" Old Mobile Balance : " + mobileBalance);
                Console.WriteLine(" Mobile OSName      : " + mobileOSName);
                Console.WriteLine(" Mobile Lock Status : Un-Lock ");

            }
            else
            {
                Console.WriteLine("...This Phone is Locked...");
            }
        }

        public void Recharge(int amount)
        {
            if (alock == false)
            {
                Console.WriteLine(" Recharge Amount : " + amount);
                int balance = ((Convert.ToInt32(mobileBalance)) + amount);
                mobileBalance = (Convert.ToString(balance));
                Console.WriteLine("Current Mobile Balance:"+mobileBalance);
            }
            else
            {
                Console.WriteLine("...This Phone is Locked...");
            }
        }

        public void CallSomeone(int timeDuration)
        {
            if (alock == false)
            {
                int cost = (timeDuration * 1);
                int balance = ((Convert.ToInt32(mobileBalance)) - cost);
                mobileBalance = (Convert.ToString(balance));
                Console.WriteLine("New Mobile Balance:" + mobileBalance);
            }
            else
            {
                Console.WriteLine("...This Phone is Locked...");
            }
        }
    }
}
