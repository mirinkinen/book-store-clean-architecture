using Catalog.BusinessRules;

namespace Catalog.BusinessRules.Authors
{
    public interface IAuthorRepository
    {
        void AddAuthor(Author author);
    }
}