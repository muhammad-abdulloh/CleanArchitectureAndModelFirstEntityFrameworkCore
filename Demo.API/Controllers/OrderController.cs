global using Demo.Infrastructure.Services.OrdersService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderRepository)
    {
        _orderService = orderRepository;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetOrdersAsync()
    {
        var res = await _orderService.GetOrdersAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetOrderByIdAsync(int id)
    {
        var res = await _orderService.GetOrderByIdAsync(id);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateOrder(int personId, string orderName)
    {
        var res = await _orderService.CreateOrderAsync(personId, orderName);
    }
}
