﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal struct BookProject
    {
        struct Book
        {

            int bookId;
            string title;
            double price;

            public void setDetails(int bookId, string title, double price)
            {
                this.bookId = bookId;
                this.title = title;
                this.price = price;
            }

            public void display()
            {
                Console.WriteLine("/---------------------------------------/");
                Console.WriteLine("The book ID is : " + bookId);
                Console.WriteLine("The book Title is : " + title);
                Console.WriteLine("The book Price is : " + price);
                Console.WriteLine("The book Type is : " + bookType.Magazine);
            }
        }

            enum bookType
            {
                Magazine, Novel, ReferenceBook, Miscellaneous

            }

            public static void Main(String[] args)
            {

                int bookId;
                string title;
                double price;

                Book book = new Book();

                Console.WriteLine("Enter Book ID: ");
                bookId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Book Title: ");
                title = Console.ReadLine();

                Console.WriteLine("Enter Book Price : ");
                price = Convert.ToInt16(Console.ReadLine());

                book.setDetails(bookId, title, price);
                book.display();

                Console.ReadKey();

            }
    }
}