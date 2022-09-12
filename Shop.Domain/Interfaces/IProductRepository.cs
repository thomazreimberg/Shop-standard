using Shop.Domain.Entities;
using System.Linq;

namespace Shop.Domain.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
    }
}
