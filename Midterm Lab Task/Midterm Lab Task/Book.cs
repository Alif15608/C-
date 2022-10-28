using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        public static int bookCounter=0;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public string BookID
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book() { }

        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            bookCounter=bookCounter+bookCopy;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name : " + bookName);
            Console.WriteLine("Book Author : " + bookAuthor);
            Console.WriteLine("Book ID : " + bookId);
            Console.WriteLine("Book Type : " + bookType);
            Console.WriteLine("Book Copy :" + bookCopy);
        }

        public void AddBookCopy(int x)
        {
            Console.WriteLine("After adding " + x + " numbers of " + bookName + " Book \n");
            bookCopy = bookCopy + x;
            bookCounter += x;
        }

        public static void showTotalBookInfo()
        {
            Console.WriteLine("Total Numbers Of Book      : " + bookCounter);
        }
    }
}
