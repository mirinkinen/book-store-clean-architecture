using System.Collections.Generic;

namespace Books2.Business
{
    public interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}