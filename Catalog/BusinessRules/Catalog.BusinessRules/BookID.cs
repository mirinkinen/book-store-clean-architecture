using System;

namespace Catalog.BusinessRules
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