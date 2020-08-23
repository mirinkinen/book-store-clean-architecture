using System;

namespace Catalog.BusinessRules
{
    public class AuthorID
    {
        private readonly Guid _authorID;

        public AuthorID(Guid authorID)
        {
            _authorID = authorID;
        }

        public Guid Value => _authorID;
    }
}