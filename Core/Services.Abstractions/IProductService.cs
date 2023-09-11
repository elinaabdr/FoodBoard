using Domain.Entities;

namespace Services.Abstractions;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetAllAsync();
}