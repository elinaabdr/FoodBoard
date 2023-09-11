using Domain.Entities;
using Domain.Repositories;
using Services.Abstractions;

namespace Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<IEnumerable<Product>> GetAllAsync() => _productRepository.GetAllProductsAsync();
}