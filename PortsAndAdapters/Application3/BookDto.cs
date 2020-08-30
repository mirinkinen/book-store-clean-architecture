using System;

namespace Application3
{
    internal class BookDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfPublication { get; set; }

        public string Genre { get; set; }

        public int AuthorId { get; set; }
    }
}