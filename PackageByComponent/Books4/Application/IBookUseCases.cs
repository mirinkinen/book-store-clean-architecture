using System.Collections.Generic;

namespace Books4.Application
{
    public interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}