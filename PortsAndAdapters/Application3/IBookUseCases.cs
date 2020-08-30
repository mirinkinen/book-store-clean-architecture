using System.Collections.Generic;

namespace Application3
{
    internal interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}