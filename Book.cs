using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp14
{
    internal class Book
    {
        public readonly string isbn;
        private string author;
        private string title;

        public Book()
        {
            this.isbn = "978-5-699-12014-7";
        }
        //не понимаю смысл задания, у каждой книги в реальной жизни разные ISBN, нет двух книг с одинаковыми ISBN

        public string Author
        { 
            get { return author; } 
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }



        public void bookInfo()
        {
            Console.WriteLine($"ISBN: {isbn}\nАвтор: {author}\nНазвание: {title}");
        }
    }
}
