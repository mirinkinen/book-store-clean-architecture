using Catalog.BusinessRules.Authors;
using Catalog.DataStore;
using Catalog.UseCases;
using Catalog.UseCases.AddAuthor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Catalog.TextUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();
            logger.LogInformation("Program starting...");

            var addAuthorUseCaseData = new AddAuthorUseCaseData
            {
                FirstName = "Jane",
                LastName = "Austen",
                DateOfBirth = new DateTime(1775, 12, 16)
            };

            var addAuthorUseCase = serviceProvider.GetService<IUseCase<AddAuthorUseCaseData>>();
            addAuthorUseCase.Execute(addAuthorUseCaseData);
        }

        private static ServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection serviceCollection)
        {
            // Configurate logging.
            serviceCollection
                .AddLogging(config =>
                {
                    config
                        .AddConsole()
                        .SetMinimumLevel(LogLevel.Debug);
                });

            // Register implementations.
            serviceCollection
                .AddSingleton<IAuthorRepository, AuthorRepository>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<IUseCase<AddAuthorUseCaseData>, AddAuthorUseCase>()
                .BuildServiceProvider();
        }
    }
}