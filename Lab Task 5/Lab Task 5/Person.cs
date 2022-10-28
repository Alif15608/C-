using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_5
{
    class Person
    {
        private string name;
        private string dob;

        public Person() { }
        
        public Person(string name, string dob)
        {
            this.name = name;
            this.dob = dob;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getName()
        {
            return name;
        }
        public string getDob()
        {
            return dob;
        }
    }
}
