using Catalog.BusinessRules.Authors;
using Microsoft.Extensions.Logging;

namespace Catalog.UseCases.AddAuthor
{
    public class AddAuthorUseCase : IUseCase<AddAuthorUseCaseData>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AddAuthorUseCase> _logger;

        public AddAuthorUseCase(
            IAuthorRepository authorRepository,
            IUnitOfWork unitOfWork,
            ILogger<AddAuthorUseCase> logger)
        {
            _authorRepository = authorRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public void Execute(AddAuthorUseCaseData data)
        {
            _logger.LogInformation($"Executing {nameof(AddAuthorUseCase)}.");

            var author = new Author(AuthorID.CreateNewId(), data.FirstName, data.LastName, data.DateOfBirth);

            _authorRepository.AddAuthor(author);
            _unitOfWork.Save();
        }
    }
}