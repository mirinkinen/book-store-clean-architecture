using System.Collections.Generic;

namespace Business
{
    public interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}