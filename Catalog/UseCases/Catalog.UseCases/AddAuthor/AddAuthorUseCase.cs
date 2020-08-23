using Catalog.BusinessRules.Authors;

namespace Catalog.UseCases.AddAuthor
{
    public class AddAuthorUseCase
    {
        private readonly AddAuthorUseCaseData _data;
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddAuthorUseCase(
            AddAuthorUseCaseData data,
            IAuthorRepository authorRepository,
            IUnitOfWork unitOfWork)
        {
            _data = data;
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
        }

        public void Execute()
        {
            var author = new Author(AuthorID.CreateNewId(), _data.FirstName, _data.LastName, _data.DateOfBirth);

            _authorRepository.AddAuthor(author);
            _unitOfWork.Save();
        }
    }
}