using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace WebApp.Controllers;

public class PayController : Controller
{
    private IProductService _productService;

    public PayController(IProductService productService)
    {
        _productService = productService;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        return View((await _productService.GetAllAsync()).GroupBy(x => x.ProductType).ToList());
    }
}   