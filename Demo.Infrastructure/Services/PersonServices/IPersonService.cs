namespace Demo.Infrastructure.Services.PersonServices;

public interface IPersonService
{
    ValueTask<Person> GetPersonByIdAsync(int id);
    ValueTask<IEnumerable<Person>> GetAllPersonsAsync();
    ValueTask<bool> DeletePersonAsync(int id);
    ValueTask<bool> UpdatePersonAsync(int id, string name);
    ValueTask<bool> CreatePersonAsync(string personName);
}
