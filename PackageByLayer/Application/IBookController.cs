using System.Collections.Generic;

namespace Application
{
    public interface IBookController
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}