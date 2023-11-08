using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Infrastructure.Services.KamronbekXServices
{
    public interface IKamronbekXService
    {
        ValueTask<bool> CreateCarAsync(string carName);
        ValueTask<bool> CreatePersonAsync(string personName);
        ValueTask<bool> CreateOrderAsync(string orderName, int personId);
        ValueTask<bool> CreatePersonCarsAsync(int personid, int carid);
        ValueTask<IEnumerable<KamronbekX>> GetAllAsync();
        ValueTask<IEnumerable<Person>> GetPeopleAsync();

    }
}