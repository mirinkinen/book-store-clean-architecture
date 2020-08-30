using Books4.Data;
using System.Collections.Generic;

namespace Books4.Business
{
    public interface IBookRepository
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}