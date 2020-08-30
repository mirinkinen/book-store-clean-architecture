using System.Collections.Generic;

namespace Books4.Business
{
    public interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}