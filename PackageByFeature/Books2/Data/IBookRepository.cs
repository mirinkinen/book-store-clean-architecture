using System.Collections.Generic;

namespace Books2.Data
{
    public interface IBookRepository
    {
        void AddBook(BookEntity book);

        IEnumerable<BookEntity> GetBooks();
    }
}