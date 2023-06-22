using DataTransferObjects.Product;
using EfCoreDbFirst.Database;

namespace EfCoreDbFirst.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task CreateProduct(CreateUpdateProductDto request)
        {
            var newProduct = new Models.Product()
            {
                Name = request.Name,
                Information = request.Information,
                CreatedBy = request.CreatedBy,
            };

            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
        }
    }
}
