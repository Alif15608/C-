using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class AddressBook : Contact
    {
        private string ownerName;
        private string info;
        Contact[] listOfContact = new Contact[1000];


        public string OwnerName
        {
            get{return ownerName;}
            set { ownerName = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }


        public AddressBook() { }
        public AddressBook(string ownerName, string info)
        {
            this.ownerName = ownerName;
            this.info = info;
        }
        public void ShowAllContactInfo()
        {
            Console.WriteLine("Owner Name    : " + ownerName);
            Console.WriteLine("Owner Address : " + info);
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] != null)
                {
                    Console.WriteLine(" Name          : " + listOfContact[i].PersonName);
                    Console.WriteLine(" Id            : " + listOfContact[i].PersonID);
                    Console.WriteLine(" Age           : " + listOfContact[i].Age);
                    Console.WriteLine(" Gender        : " + listOfContact[i].Gender);
                    Console.WriteLine(" Mobile Number : " + listOfContact[i].MobileNumber);
                    Console.WriteLine();
                }
            }
        }

        public void AddContact(Contact con)
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] == null)
                {
                    listOfContact[i] = con;
                    Console.WriteLine("..........." + listOfContact[i].PersonName + "  Contact Add Succesfully...........\n");
                    break;
                }
            }
        }
        public void DeleteContact(Contact con)
        {
            for (int i = 0; i < listOfContact.Length; i++)
            {
                if (listOfContact[i] == con)
                {
                    Console.WriteLine("..........." + listOfContact[i].PersonName + "  Contact Deleted Succesfully...........\n");
                    listOfContact[i] = null;
                    break;
                }
            }
        }


    }

}