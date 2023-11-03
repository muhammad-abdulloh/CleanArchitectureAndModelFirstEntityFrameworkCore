using Demo.Application.Repositories.KamronbekXRepositories;
using Demo.Infrastructure.Services.KamronbekXServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KamronbekXController : ControllerBase
    {
        private readonly IKamronbekXService kamronbekService;

        public KamronbekXController(IKamronbekXService kamronbekService)
        {
            this.kamronbekService = kamronbekService;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAll()
        {
            var entities = await kamronbekService.GetAllAsync();
            return Ok(entities);
        }
    }
}
