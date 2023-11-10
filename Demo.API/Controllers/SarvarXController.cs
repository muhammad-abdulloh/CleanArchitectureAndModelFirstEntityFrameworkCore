using Demo.Application.Repositories;
using Demo.Infrastructure.Services.SarvarXServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SarvarXController : ControllerBase
    {
        private readonly ISarvarXService _sarvarXService;
        public SarvarXController(ISarvarXService service)
        {
            _sarvarXService = service;
            
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllSarvarX()
        {
            
            return Ok(await _sarvarXService.GetAllSarvarX());


        }
    }
}
