using Microsoft.AspNetCore.Mvc;

namespace NetCommerce.Controllers;

public class AuthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}