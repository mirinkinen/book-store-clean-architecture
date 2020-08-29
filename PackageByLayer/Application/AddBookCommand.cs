using Business;
using System;

namespace Application
{
    public class AddBookCommand
    {
        public void Execute(BookCreationDto bookCreationDto)
        {
            var book = new Book
            {
                AuthorId = bookCreationDto.AuthorId,
                DateOfPublication = bookCreationDto.DateOfPublication,
                Genre = (Genre)Enum.Parse(typeof(Genre), bookCreationDto.Genre, true),
                Name = bookCreationDto.Name
            };

            var bookService = new BookService();
            bookService.AddBook(book);
        }
    }
}