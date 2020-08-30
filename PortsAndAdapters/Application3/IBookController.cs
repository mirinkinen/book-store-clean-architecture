using System.Collections.Generic;

namespace Application3
{
    public interface IBookController
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}