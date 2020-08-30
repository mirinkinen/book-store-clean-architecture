using System.Collections.Generic;

namespace Business3
{
    internal interface IBookRepository
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}