using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    internal class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Name))
            {
                throw new ArgumentException();
            }

            var bookEntity = new BookEntity
            {
                AuthorId = book.AuthorId,
                DateOfPublication = book.DateOfPublication,
                Genre = (Data.Genre)book.Genre
            };

            _bookRepository.AddBook(bookEntity);

            book.Id = bookEntity.Id;
        }

        public IEnumerable<Book> GetBooks()
        {
            var bookEntities = _bookRepository.GetBooks();

            return bookEntities.Select(entity => new Book
            {
                AuthorId = entity.AuthorId,
                DateOfPublication = entity.DateOfPublication,
                Genre = (Genre)entity.Genre,
                Id = entity.Id,
                Name = entity.Name
            });
        }
    }
}