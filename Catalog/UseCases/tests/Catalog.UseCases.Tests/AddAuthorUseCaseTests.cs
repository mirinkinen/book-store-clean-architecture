using Catalog.BusinessRules.Authors;
using Catalog.UseCases.AddAuthor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Catalog.UseCases.Tests
{
    [TestClass]
    public class AddAuthorUseCaseTests
    {
        [TestMethod]
        public void AddAuthorUseCase_WithValidData_AuthorIsAdded()
        {
            // Arrage
            var firstName = "Jane";
            var lastName = "Austen";
            var dateOfBirth = new DateTimeOffset(new DateTime(1775, 12, 16));
            var data = new AddAuthorUseCaseData(firstName, lastName, dateOfBirth);

            var authorRepositoryMock = new Mock<IAuthorRepository>();
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            var addAuthorUseCase = new AddAuthorUseCase(data, authorRepositoryMock.Object, unitOfWorkMock.Object);

            // Act
            addAuthorUseCase.Execute();


            // Assert
            authorRepositoryMock.Verify(m => m.AddAuthor(It.Is<Author>(
                a => a.ID != null &&
                a.ID.Value != Guid.Empty &&
                a.FirstName == firstName &&
                a.LastName == lastName &&
                a.DateOfBirth == dateOfBirth)), Times.Once);
            unitOfWorkMock.Verify(m => m.Save(), Times.Once);

            authorRepositoryMock.VerifyNoOtherCalls();
            unitOfWorkMock.VerifyNoOtherCalls();
        }
    }
}