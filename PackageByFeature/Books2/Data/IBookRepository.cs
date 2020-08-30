using System.Collections.Generic;

namespace Books2.Data
{
    internal interface IBookRepository
    {
        void AddBook(BookEntity book);

        IEnumerable<BookEntity> GetBooks();
    }
}