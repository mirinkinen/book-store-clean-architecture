using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Catalog.BusinessRules.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Book_Constructor_CreatesABook()
        {
            var bookID = new BookID(Guid.NewGuid());
            var title = "The best book ever";
            var dateOfPublication = DateTimeOffset.UtcNow;
            var category = Category.Fantasy;
            var authorID = new AuthorID(Guid.NewGuid());

            var book = new Book(bookID, title, dateOfPublication, category, authorID);

            book.ID.Should().Be(bookID);
            book.Title.Should().Be(title);
            book.DateOfPublication.Should().Be(dateOfPublication);
            book.Category.Should().Be(category);
            book.AuthorID.Should().Be(authorID);
        }
    }
}