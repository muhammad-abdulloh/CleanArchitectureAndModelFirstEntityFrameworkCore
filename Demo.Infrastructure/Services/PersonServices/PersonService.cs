using Demo.Application.Repositories.PersonRepositories;

namespace Demo.Infrastructure.Services.PersonServices;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async ValueTask<bool> CreatePersonAsync(string name)
    {
        var person = new Person { Name = name };
        return await _personRepository.CreateAsync(person);
    }

    public async ValueTask<bool> DeletePersonAsync(int id)
    {
        return await _personRepository.DeleteAsync(id);
    }

    public async ValueTask<IEnumerable<Person>> GetAllPersonsAsync()
    {
        return await _personRepository.GetAllPersonAsync();
    }

    public async ValueTask<Person> GetPersonByIdAsync(int id)
    {
        return await _personRepository.GetPersonByIdAsync(id);
    }

    public async ValueTask<bool> UpdatePersonAsync(int id, string name)
    {
        var person = new Person { Id = id, Name = name };
        return await _personRepository.UpdateAsync(person);
    }
}
