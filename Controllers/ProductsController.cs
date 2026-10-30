
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Keyboard",
                Price = 50m,
                Stock = 10
            },
            new Product
            {
                Id = 2,
                Name = "Mouse",
                Price = 25m,
                Stock = 20
            },
            new Product
            {
                Id = 3,
                Name = "Monitor",
                Price = 200m,
                Stock = 5
            }
        };

        return View(products);
    }
}
