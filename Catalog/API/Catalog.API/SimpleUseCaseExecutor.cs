using Catalog.BusinessRules.Authors;
using Catalog.UseCases;
using Catalog.UseCases.AddAuthor;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Catalog.API
{
    public class SimpleUseCaseExecutor : IUseCaseExecutor
    {
        private readonly IServiceProvider _serviceProvider;

        public SimpleUseCaseExecutor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Execute<TUseCaseData>(TUseCaseData useCaseData) where TUseCaseData : IUseCaseData
        {
            if (useCaseData is AddAuthorUseCaseData data)
            {
                var useCase = _serviceProvider.GetRequiredService<IUseCase<AddAuthorUseCaseData>>();

                useCase.Execute(data);
                return;
            }

            throw new NotImplementedException($"UseCase not found for data type: '{useCaseData.GetType()}'.");
        }
    }
}