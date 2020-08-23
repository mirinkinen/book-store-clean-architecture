using Catalog.BusinessRules.Authors;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Catalog.BusinessRules.Tests
{
    [TestClass]
    public class AuthorTests
    {
        [TestMethod]
        public void Author_Constructor_CreatesAnAuthor()
        {
            var authorID = new AuthorID(Guid.NewGuid());
            var firstName = "Ernest";
            var lastName = "Hemingway";
            var dateOfBirth = new DateTimeOffset(new DateTime(1899, 7, 21));

            var book = new Author(authorID, firstName, lastName, dateOfBirth);

            book.ID.Should().Be(authorID);
            book.FirstName.Should().Be(firstName);
            book.LastName.Should().Be(lastName);
            book.DateOfBirth.Should().Be(dateOfBirth);
        }
    }
}