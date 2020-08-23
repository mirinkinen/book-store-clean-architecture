using System;

namespace Catalog.BusinessRules
{
    public class Author
    {
        public AuthorID ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public Author(AuthorID id, string firstName, string lastName, DateTimeOffset dateOfBirth)
        {
            ID = id ?? throw new ArgumentNullException(nameof(id));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            DateOfBirth = dateOfBirth;
        }
    }
}