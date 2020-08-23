namespace Catalog.UseCases
{
    public interface IUseCase<in TUseCaseData> where TUseCaseData : IUseCaseData
    {
        void Execute(TUseCaseData data);
    }
}