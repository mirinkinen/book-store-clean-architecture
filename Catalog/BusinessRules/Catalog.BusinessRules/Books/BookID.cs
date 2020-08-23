using System;

namespace Catalog.BusinessRules.Books
{
    public class BookID
    {
        private readonly Guid _bookID;

        public BookID(Guid bookID)
        {
            _bookID = bookID;
        }

        public Guid Value => _bookID;
    }
}