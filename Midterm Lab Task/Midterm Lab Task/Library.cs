using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Task
{
    class Library : Book
    {
        private string libName;
        private string libAddress;
        private Book[] listOfBook=new Book[100];
        private int totalBook;

        public string LibraryName
        {
            get { return libName; }
            set { libName = value; }
        }

        public string LibraryAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        public Library() { }

        public Library(string libName, string libAddress, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
        }

        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name    : " + libName);
            Console.WriteLine("Library Address : " + libAddress);
            Console.WriteLine("Total Book      : " + totalBook);
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] != null)
                {
                    Console.WriteLine("Book Name: " + BookName);
                    Console.WriteLine("Book Author: " + BookAuthor);
                    Console.WriteLine("Book ID: " + BookID);
                    Console.WriteLine("Book Type : " + BookType);
                    Console.WriteLine("Book Copy :" + BookCopy);
                    Console.WriteLine();
                }
            }
        }

        public void AddNewBook(Book book)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == null)
                {
                    listOfBook[i] = book;
                    Console.WriteLine("\n...." + listOfBook[i].BookName + "  Book Added to the Library....\n");
                    break;
                }
            }
        }

        public void DeleteBook(Book book)
        {

            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == book)
                {
                    Console.WriteLine("\n...." + listOfBook[i].BookName + "  Book Deleted From the Library....\n");
                    listOfBook[i] = null;
                    break;
                }
            }
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i] == null)
                {
                    listOfBook[i] = book;
                    Console.WriteLine("\n...." + listOfBook[i].BookName + "  New Book Added to the Library....\n");
                    break;
                }
            }
            bookCounter = bookCounter + copy;
            Console.WriteLine("Now Total Book Number :" + bookCounter);
        }
     }

 }
