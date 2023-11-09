using Demo.Application.Repositories.KamronbekXRepositories;
using Demo.Application.Repositories.PersonRepositories;
using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Infrastructure.Services.KamronbekXServices;

public class KamronbekXService : IKamronbekXService
{
    private readonly IKamronbekRepository kamronbekRepository;
    private readonly IPersonRepository _personRepository;

    public KamronbekXService(IKamronbekRepository kamronbekRepository, IPersonRepository person)
    {
        this.kamronbekRepository = kamronbekRepository;
        _personRepository = person;
    }

    public async ValueTask<bool> AddorderToPerson(int id, string name)
    {
        var order = new Order() { Name = name };
        return await _personRepository.AddOrdertoPerson(id, order);
    }

    public async ValueTask<bool> CreateCarAsync(string carName)
    {
        var car = new Car() { Name = carName };
        return await kamronbekRepository.CreateCarAsync(car);
    }

    public async ValueTask<bool> CreateOrderAsync(string orderName, int personId)
    {
        var order = new Order() { 
            Name = orderName,
            PersonId = personId
        };
        return true;// await kamronbekRepository.CreateOrderAsync(order);
    }

    public async ValueTask<bool> CreatePersonAsync(string personName)
    {
        var person = new Person() { Name = personName };
        return await kamronbekRepository.CreatePersonAsync(person);
    }

    public async ValueTask<bool> CreatePersonCarsAsync(int personid, int carid)
    {
        var carperson = new PersonCars()
        {
            PersonId = personid,
            CarId = carid
        };
        return await kamronbekRepository.CreatePersonCarsAsync(carperson);
    }

    public async ValueTask<IEnumerable<KamronbekX>> GetAllAsync()
    {
        IEnumerable<KamronbekX> kamronbekXes = await kamronbekRepository.GetAllAsync();
        return kamronbekXes ?? Enumerable.Empty<KamronbekX>();
    }

    public async ValueTask<IEnumerable<Person>> GetPeopleAsync()
    {
        IEnumerable<Person> people = await kamronbekRepository.GetPeopleAsync();
        return people ?? Enumerable.Empty<Person>();
    }
}
