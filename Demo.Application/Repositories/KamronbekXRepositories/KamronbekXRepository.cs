using Demo.Application.DataAcsess;
using Demo.Domain.Models.KamronbekXModel;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Repositories.KamronbekXRepositories;

public class KamronbekXRepository : IKamronbekRepository
{
    private readonly DemoDbContext dbContext;

    public KamronbekXRepository(DemoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async ValueTask<bool> CreateCarAsync(Car car)
    {
        await dbContext.Cars.AddAsync(car);
        int result = await dbContext.SaveChangesAsync();
        return result > 0;
    }

    public async ValueTask<bool> CreateOrderAsync(Order order)
    {
        await dbContext.AddAsync(order);
        int res = await dbContext.SaveChangesAsync();
        return res > 0;
    }

    public async ValueTask<bool> CreatePersonAsync(Person person)
    {
        await dbContext.Persons.AddAsync(person);
        int result = await dbContext.SaveChangesAsync();
        return result > 0;
    }

    public async ValueTask<bool> CreatePersonCarsAsync(PersonCars personcars)
    {
        await dbContext.PersonCars.AddAsync(personcars);

        int result = await dbContext.SaveChangesAsync();
        return result > 0;
    }

    public async ValueTask<IEnumerable<KamronbekX>> GetAllAsync()
    {
        IEnumerable<KamronbekX> entites = await dbContext.KamronbekXes.ToListAsync();
        return entites ?? Enumerable.Empty<KamronbekX>();
    }


    async ValueTask<IEnumerable<Person>> IKamronbekRepository.GetPeopleAsync()
    {
        IEnumerable<Person> people = await dbContext.Persons
            .Include(x => x.PersonCars)
            .ThenInclude(x => x.Car)
            .Include(x=>x.Orders)
            .ToListAsync();

        return people ?? Enumerable.Empty<Person>();
    }
}
