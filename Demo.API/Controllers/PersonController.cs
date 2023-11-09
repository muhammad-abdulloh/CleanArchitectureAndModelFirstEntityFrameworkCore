using Demo.Infrastructure.Services.PersonServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetPeopleAsync()
        {
            var people = await _personService.GetAllPersonsAsync();
            return Ok(people);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetPersonById(int id)
        {
            var person = await _personService.GetPersonByIdAsync(id);
            return Ok(person);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreatePersonAsync(string name)
        {
            var res = await _personService.CreatePersonAsync(name);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdatePersonAsync(int id, string name)
        {
            var res = await _personService.UpdatePersonAsync(id, name);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            var res = await _personService.DeletePersonAsync(id);
            return Ok(res);
        }

    }
}
