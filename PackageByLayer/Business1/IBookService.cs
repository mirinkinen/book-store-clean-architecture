using System.Collections.Generic;

namespace Business1
{
    internal interface IBookService
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}