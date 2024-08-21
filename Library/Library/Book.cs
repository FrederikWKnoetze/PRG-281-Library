using System;
using System.Collections.Generic;
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
        private bool borrowed;
        private List<string> genres;

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
        public bool Borrowed
        {   get { return borrowed; }
            set { borrowed = value; } 
        }
        public List<string> Genres
        {   get { return genres; } 
            set { genres = value; } 
        }

        Book(string _ISBN, string _Author, string _Title, bool _Borrowed, List<string> _Genres)
        {
            this.isbn = _ISBN;
            this.title = _Title;
            this.author = _Author;
            this.borrowed = _Borrowed;
            this.genres = _Genres;
        }
    }
}
