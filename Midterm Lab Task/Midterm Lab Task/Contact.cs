using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;
       
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        public string PersonID
        {
            get { return personId; }
            set { personId = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Contact() { }
        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }

    
        public void ShowPersonInfo()
        {
            Console.WriteLine("Person Name :" +personName);
            Console.WriteLine("Person ID :"+personId);
            Console.WriteLine("Age :"+age);
            Console.WriteLine("Mobile Number :"+mobileNumber);
            Console.WriteLine("Gender :"+gender);
        }

        public void DetectMobileOperator()
        {
            if (mobileNumber == "017********")
                Console.WriteLine("Mobile Operator is GP");
            if (mobileNumber == "018********")
                Console.WriteLine("Mobile Operator is Robi");
            if (mobileNumber == "019********")
                Console.WriteLine("Mobile Operator is Banglalink");
            if (mobileNumber == "016********")
                Console.WriteLine("Mobile Operator is Airtel");
            if (mobileNumber == "015********")
                Console.WriteLine("Mobile Operator is Teletalk");
        }
    }
}
