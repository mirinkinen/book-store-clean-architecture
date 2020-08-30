using System.Collections.Generic;

namespace Data1
{
    public interface IBookRepository
    {
        void AddBook(BookEntity book);

        IEnumerable<BookEntity> GetBooks();
    }
}