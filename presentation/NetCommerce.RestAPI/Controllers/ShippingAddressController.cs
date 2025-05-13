using Microsoft.AspNetCore.Mvc;

namespace NetCommerce.Controllers;

public class ShippingAddressController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}