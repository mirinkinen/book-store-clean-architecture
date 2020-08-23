using Catalog.BusinessRules.Authors;

namespace Catalog.UseCases.AddAuthor
{
    public class AddAuthorUseCase : IUseCase<AddAuthorUseCaseData>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddAuthorUseCase(IAuthorRepository authorRepository, IUnitOfWork unitOfWork)
        {
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
        }

        public void Execute(AddAuthorUseCaseData data)
        {
            var author = new Author(AuthorID.CreateNewId(), data.FirstName, data.LastName, data.DateOfBirth);

            _authorRepository.AddAuthor(author);
            _unitOfWork.Save();
        }
    }
}