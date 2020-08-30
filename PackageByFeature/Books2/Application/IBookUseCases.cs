using System.Collections.Generic;

namespace Books2.Application
{
    public interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}