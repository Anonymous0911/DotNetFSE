using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using System.Text.Json;

namespace OrderService.Controllers;

[ApiController]
[Route("orders")]
public class OrdersController : ControllerBase
{
    private readonly IHttpClientFactory _factory;

    public OrdersController(IHttpClientFactory factory)
    {
        _factory = factory;
    }

    private static List<Order> orders = new();

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(Order order)
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync(
            $"http://localhost:5008/products/{order.ProductId}");

        if (!response.IsSuccessStatusCode)
        {
            return BadRequest("Invalid Product");
        }

        var product = await response.Content.ReadAsStringAsync();

        orders.Add(order);

        return Ok(new
        {
            Message = "Order Created",
            Product = JsonSerializer.Deserialize<object>(product),
            Order = order
        });
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("Order Service Running");
    }
}