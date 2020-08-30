using System.Collections.Generic;

namespace Books2.Application
{
    internal interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}