using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string ISBN;
        private string Title;
        private string Author;
        private bool Borrowed;
        private List<string> Genres;

        public string isbn { get { return ISBN; } set { ISBN = value; } }
        public string title { get { return Title; } set { Title = value; } }
        public string author { get { return Author; } set { Author = value; } }
        public bool borrowed { get { return Borrowed; } set { Borrowed = value; } }
        public List<string> genres { get { return Genres; } set { Genres = value; } }

        Book(string _ISBN, string _Author, string _Title, bool _Borrowed, List<string> _Genres)
        {
            this.ISBN = _ISBN;
            this.Title = _Title;
            this.Author = _Author;
            this.Borrowed = _Borrowed;
            this.Genres = _Genres;
        }
    }
}
