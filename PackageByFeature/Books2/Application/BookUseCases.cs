using Books2.Business;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Books2.Application
{
    public class BookUseCases : IBookUseCases
    {
        private readonly IBookService _bookService;

        public BookUseCases(IBookService bookService)
        {
            _bookService = bookService;
        }

        public void AddBook(BookCreationDto bookCreationDto)
        {
            var book = new Book
            {
                AuthorId = bookCreationDto.AuthorId,
                DateOfPublication = bookCreationDto.DateOfPublication,
                Genre = (Genre)Enum.Parse(typeof(Genre), bookCreationDto.Genre, true),
                Name = bookCreationDto.Name
            };

            _bookService.AddBook(book);
        }

        public IEnumerable<BookDto> GetBooks()
        {
            var books = _bookService.GetBooks();

            return books.Select(book => new BookDto
            {
                AuthorId = book.AuthorId,
                DateOfPublication = book.DateOfPublication,
                Genre = book.Genre.ToString(),
                Id = book.Id,
                Name = book.Name
            });
        }
    }
}