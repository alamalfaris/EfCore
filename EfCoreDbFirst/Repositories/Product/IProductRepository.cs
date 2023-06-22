using DataTransferObjects.Product;

namespace EfCoreDbFirst.Repositories.Product
{
    public interface IProductRepository
    {
        Task CreateProduct(CreateUpdateProductDto request);
    }
}
