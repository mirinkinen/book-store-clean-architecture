using System.Collections.Generic;

namespace Data1
{
    internal interface IBookRepository
    {
        void AddBook(BookEntity book);

        IEnumerable<BookEntity> GetBooks();
    }
}