using System.Collections.Generic;

namespace Application1
{
    internal interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}