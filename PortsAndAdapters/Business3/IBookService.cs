using System.Collections.Generic;

namespace Business3
{
    public interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}