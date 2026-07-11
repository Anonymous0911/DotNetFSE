using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers;

[ApiController]
[Route("products")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new()
    {
        new Product{Id=1,Name="Laptop",Price=60000},
        new Product{Id=2,Name="Mouse",Price=800},
        new Product{Id=3,Name="Keyboard",Price=1500}
    };

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if(product == null)
            return NotFound();

        return Ok(product);
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("Product Service Running");
    }
}