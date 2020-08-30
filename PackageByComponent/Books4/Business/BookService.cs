using System;
using System.Collections.Generic;

namespace Books4.Business
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

            _bookRepository.AddBook(book);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }
    }
}