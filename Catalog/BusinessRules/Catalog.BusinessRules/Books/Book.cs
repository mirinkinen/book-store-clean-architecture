using Catalog.BusinessRules.Authors;
using System;

namespace Catalog.BusinessRules.Books
{
    public class Book
    {
        public BookID ID { get; private set; }

        public string Title { get; private set; }

        public DateTimeOffset DateOfPublication { get; private set; }

        public Category Category { get; private set; }

        public AuthorID AuthorID { get; private set; }

        public Book(BookID id, string title, DateTimeOffset dateOfPublication, Category category, AuthorID authorID)
        {
            ID = id ?? throw new ArgumentNullException(nameof(id));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            DateOfPublication = dateOfPublication;
            Category = category;
            AuthorID = authorID ?? throw new ArgumentNullException(nameof(authorID));
        }
    }
}