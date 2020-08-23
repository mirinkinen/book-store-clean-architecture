using System;

namespace Catalog.UseCases.AddAuthor
{
    public class AddAuthorUseCaseData : IUseCaseData
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }
    }
}