namespace DemoLibraryInterface
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadLeft { get; }
    }
}
