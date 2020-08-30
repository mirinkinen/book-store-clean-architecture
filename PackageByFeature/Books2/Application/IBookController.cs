using System.Collections.Generic;

namespace Books2.Application
{
    public interface IBookController
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}