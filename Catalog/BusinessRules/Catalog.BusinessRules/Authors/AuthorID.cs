using System;

namespace Catalog.BusinessRules.Authors
{
    public class AuthorID
    {
        private readonly Guid _authorID;

        public AuthorID(Guid authorID)
        {
            _authorID = authorID;
        }

        public Guid Value => _authorID;

        public static AuthorID CreateNewId()
        {
            return new AuthorID(Guid.NewGuid());
        }
    }
}