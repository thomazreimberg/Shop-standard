using Shop.Application.ViewModels;
using Shop.Domain.Interfaces;
using System.Linq;

namespace Shop.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductViewModel GetProdutcts() =>
            new ProductViewModel()
            {
                Product = _productRepository.GetProducts().ToList(),
            };
    }
}
