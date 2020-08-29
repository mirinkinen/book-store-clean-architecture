using System.Collections.Generic;

namespace Data
{
    public interface IBookRepository
    {
        void AddBook(BookEntity book);

        IEnumerable<BookEntity> GetBooks();
    }
}