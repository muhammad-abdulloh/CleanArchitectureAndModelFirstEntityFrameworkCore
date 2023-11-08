using Demo.Infrastructure.Services.KamronbekXServices;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]/[action]")]
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
            return Ok();
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetPeopleAsync()
        {
            var people = await kamronbekService.GetPeopleAsync();
            return Ok(people);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreatePersonAsync(string name)
        {
            bool res = await kamronbekService.CreatePersonAsync(name);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCarAsync(string name)
        {
            bool res = await kamronbekService.CreateCarAsync(name);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreatePersonCarsAsync(int pid, int cid)
        {
            bool res = await kamronbekService.CreatePersonCarsAsync(pid, cid);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateOrderAsync(string order, int personId)
        {
            bool res = await kamronbekService.CreateOrderAsync(order, personId);
            return Ok(res);
        }
    }
}
