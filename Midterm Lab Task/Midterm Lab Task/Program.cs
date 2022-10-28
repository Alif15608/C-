using System;

namespace Midterm_Lab_Task
{
    class Program
    {
        
        static void Main(string[] args)
        {


            Account a1 = new Account("Alif", "alif69", 1500);
            a1.Show();
            a1.Withdraw(600);
            a1.Deposit(500);
            a1.Transfer(1000, "Adol");
            Console.WriteLine();

            Book b1 = new Book("Dark Tales", "Shirley Jackson", "Dk 101", "Horror", 11);
            b1.ShowInfo();
            Console.WriteLine();
            Book b2 = new Book("Truth", "Peter Temple", "PT 102", "Crime Novel", 7);
            b2.ShowInfo();
            Console.WriteLine();
            Book b3 = new Book("Edge of Heaven", "RB Kelly", "EH 103", "Science Fiction", 19);
            Book.showTotalBookInfo();
            Console.WriteLine();
            b2.AddBookCopy(5);
            Book.showTotalBookInfo();
            Console.WriteLine();

            Contact c1 = new Contact("Alif", "201", 21, "017********", 'M');
            c1.ShowPersonInfo();
            c1.DetectMobileOperator();
            Console.WriteLine();
            Contact c2 = new Contact("Adol", "202", 20, "019********", 'F');
            c2.ShowPersonInfo();
            c2.DetectMobileOperator();
            Console.WriteLine();

            Course c = new Course("Object Oriented Programming 2", "CSC2210", 3);
            c.ShowCourseInfo();
            Console.WriteLine();

            Course c3 = new Course("Digital Logic & Circuits Lab", "EEE3102", 1);
            c3.ShowCourseInfo();
            Console.WriteLine();

            Mobile m = new Mobile("Alif", "017********", "50", "Android", false);
            m.showInfo();
            m.Recharge(20);
            m.CallSomeone(29);
            Console.WriteLine();


            Mobile m2 = new Mobile("Adol", "019********", "90", "ISO", true);
            m2.showInfo();
            m2.Recharge(30);
            m2.CallSomeone(25);
            Console.WriteLine();

            AddressBook ab = new AddressBook("Shakil", "Mohammadpur");
            ab.ShowAllContactInfo();
            Console.WriteLine();
            Contact c5 = new Contact("Shakil", "203", 22, "018********", 'M');
            ab.AddContact(c5);
            c5.ShowPersonInfo();
            ab.DeleteContact(c5);

            Library l1 = new Library("Fifa21", "Mohammadpur", 112);
            l1.ShowLibInfo();
            l1.AddNewBook(b3);
            b3.ShowInfo();
            l1.DeleteBook(b3);
            Book b4 = new Book("These Women", "Ivy Pochoda", "TW 104", "Thriller", 5);
            l1.AddNewBookCopy(b4, 12);
            b4.ShowInfo();
        }
    }
}
