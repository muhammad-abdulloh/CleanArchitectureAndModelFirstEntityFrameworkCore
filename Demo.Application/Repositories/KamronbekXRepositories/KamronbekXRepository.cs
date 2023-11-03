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
    public async ValueTask<IEnumerable<KamronbekX>> GetAllAsync()
    {
        IEnumerable<KamronbekX> entites = await dbContext.KamronbekXes.ToListAsync();
        return entites ?? Enumerable.Empty<KamronbekX>();
    }
}
