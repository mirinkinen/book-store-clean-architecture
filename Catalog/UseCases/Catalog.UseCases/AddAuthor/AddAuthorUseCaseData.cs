using Catalog.BusinessRules.Authors;
using System;

namespace Catalog.UseCases.AddAuthor
{
    public class AddAuthorUseCaseData
    {
        public readonly string FirstName;

        public readonly string LastName;

        public readonly DateTimeOffset DateOfBirth;

        public AddAuthorUseCaseData(string firstName, string lastName, DateTimeOffset dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }
}