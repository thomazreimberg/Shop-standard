using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Services;
using Shop.Application.ViewModels;

namespace Shop.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        public ProductViewModel ProductViewModel { get; set; } = new ProductViewModel();
        private IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        
        public void OnGet()
        {

            ProductViewModel = _productService.GetProdutcts();
        }
    }
}
