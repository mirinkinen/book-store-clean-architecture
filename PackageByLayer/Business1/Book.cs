using System;

namespace Business1
{
    internal class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfPublication { get; set; }

        public Genre Genre { get; set; }

        public int AuthorId { get; set; }
    }
}