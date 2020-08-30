using System.Collections.Generic;

namespace Business3
{
    internal interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}