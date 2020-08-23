using Catalog.UseCases.AddAuthor;
using Microsoft.Extensions.Logging;

namespace Catalog.DataStore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(ILogger<UnitOfWork> logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.LogInformation("Saving data to data store.");
            return;
        }
    }
}