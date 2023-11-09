using Demo.Domain.DTOs.KamronbekXDTOs;
using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Application.Repositories.KamronbekXRepositories;

public interface IKamronbekRepository
{
    public ValueTask<IEnumerable<KamronbekX>> GetAllAsync();
    public ValueTask<IEnumerable<Person>> GetPeopleAsync();
    public ValueTask<bool> CreatePersonAsync(Person person);
    public ValueTask<bool> CreateCarAsync(Car car);
    public ValueTask<bool> CreatePersonCarsAsync(PersonCars personCars);
}
