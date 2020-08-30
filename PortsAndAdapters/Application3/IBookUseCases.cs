using System.Collections.Generic;

namespace Application3
{
    public interface IBookUseCases
    {
        void AddBook(BookCreationDto bookCreationDto);

        IEnumerable<BookDto> GetBooks();
    }
}