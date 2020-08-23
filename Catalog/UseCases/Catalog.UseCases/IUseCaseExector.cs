namespace Catalog.UseCases
{
    public interface IUseCaseExecutor
    {
        void Execute<TUseCaseData>(TUseCaseData useCaseData) where TUseCaseData : IUseCaseData;
    }
}