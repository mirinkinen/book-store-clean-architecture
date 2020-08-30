using System;
using System.Collections.Generic;

namespace Business
{
    internal class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Book> Books { get; }
    }
}