using Demo.Infrastructure.Services.SalohiddinX;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SalohiddinController : ControllerBase
{
    private ISalohiddinXService _service;

    public SalohiddinController(ISalohiddinXService xService)
    {
        _service = xService;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetAllAsync()
        => Ok(await _service.GetAllUsersAsync());

}
