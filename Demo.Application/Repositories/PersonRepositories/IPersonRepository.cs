namespace Demo.Application.Repositories.PersonRepositories;

public interface IPersonRepository
{
    public ValueTask<IEnumerable<Person>> GetAllPersonAsync();
    public ValueTask<Person> GetPersonByIdAsync(int id);
    public ValueTask<bool> UpdateAsync(Person person);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<bool> CreateAsync(Person person);
    //public ValueTask<bool> AddOrdertoPerson(int personId, Order order);
}
