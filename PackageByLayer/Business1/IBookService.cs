using System.Collections.Generic;

namespace Business1
{
    public interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}