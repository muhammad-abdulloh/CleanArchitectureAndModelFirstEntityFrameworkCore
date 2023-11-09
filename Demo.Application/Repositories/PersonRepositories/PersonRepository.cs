namespace Demo.Application.Repositories.PersonRepositories;

public class PersonRepository : IPersonRepository
{
    private readonly DemoDbContext _dbContext;

    public PersonRepository(DemoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<bool> CreateAsync(Person person)
    {
        await _dbContext.AddAsync(person);
        int res = await _dbContext.SaveChangesAsync();
        return res > 0;
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var person = await _dbContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
        if (person is null)
        {
            return false;
        }
        int res = await _dbContext.SaveChangesAsync();
        return res > 0;
    }

    public async ValueTask<IEnumerable<Person>> GetAllPersonAsync()
    {
        return await _dbContext.Persons.ToListAsync();
    }

    public async ValueTask<Person> GetPersonByIdAsync(int id)
    {
        var person = await _dbContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
        return person;
    }

    public async ValueTask<bool> UpdateAsync(Person person)
    {
        var tempperson = await _dbContext.Persons.FirstOrDefaultAsync(x => x.Id == person.Id);
        if (tempperson is null)
            return false;
        tempperson.Name = person.Name;
        int res = await _dbContext.SaveChangesAsync();
        return (res > 0);
    }
}
