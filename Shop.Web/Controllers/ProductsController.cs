using Microsoft.AspNetCore.Mvc;
using Shop.Application.Services;

namespace Shop.Web.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index() =>
            View(_productService.GetProdutcts());
    }
}
