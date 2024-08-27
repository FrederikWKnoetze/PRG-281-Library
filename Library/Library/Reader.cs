using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Reader
    {
        private string id;
        private string firstname;
        private string lastname;
        private List<Book> books;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

        public Reader(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstname = firstName;
            this.lastname = lastName;
            this.books = new List<Book>();
        }
    }
}
