using System.Collections.Generic;

namespace Books4.Business
{
    internal interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}