using System.Collections.Generic;

namespace Business3
{
    public interface IBookRepository
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}