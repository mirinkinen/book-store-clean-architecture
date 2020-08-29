using Application;
using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/books
        [HttpGet]
        public IEnumerable<BookDto> Get()
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

        // POST api/books
        [HttpPost]
        public IActionResult Post([FromBody] BookCreationDto bookCreationDto)
        {
            var book = new Book
            {
                AuthorId = bookCreationDto.AuthorId,
                DateOfPublication = bookCreationDto.DateOfPublication,
                Genre = (Genre)Enum.Parse(typeof(Genre), bookCreationDto.Genre, true),
                Name = bookCreationDto.Name
            };

            _bookService.AddBook(book);

            return Ok();
        }
    }
}