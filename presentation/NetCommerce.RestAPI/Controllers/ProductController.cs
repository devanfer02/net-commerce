using Microsoft.AspNetCore.Mvc;

namespace NetCommerce.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}