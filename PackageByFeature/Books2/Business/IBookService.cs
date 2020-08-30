using System.Collections.Generic;

namespace Books2.Business
{
    internal interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}