using Microsoft.AspNetCore.Mvc;

namespace NetCommerce.Controllers;

public class OrderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}