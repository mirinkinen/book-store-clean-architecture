using Books4.Data;
using System.Collections.Generic;

namespace Books4.Business
{
    internal interface IBookRepository
    {
        void AddBook(Book book);

        IEnumerable<Book> GetBooks();
    }
}