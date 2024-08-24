using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string isbn;
        private string title;
        private string author;
        private int borrowed;
        private string genres;

        public string ISBN
        {   get { return isbn; } 
            set { isbn = value; } 
        }
        public string Title
        {   get { return title; } 
            set { title = value; } 
        }
        public string Author
        {   get { return author; }
            set { author = value; } 
        }
        public int Borrowed
        {   get { return borrowed; }
            set { borrowed = value; } 
        }
        public string Genres
        {   get { return genres; } 
            set { genres = value; } 
        }

        public Book(string _ISBN, string _Title, string _Author, string _Genres, int _Borrowed)
        {
            this.isbn = _ISBN;
            this.title = _Title;
            this.author = _Author;
            this.genres = _Genres;
            this.borrowed = _Borrowed;
        }
    }
}
