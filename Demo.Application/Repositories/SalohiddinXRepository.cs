using Demo.Application.DataAcsess;
using Demo.Domain.BaseModels.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Repositories;

public class SalohiddinXRepository : ISalohiddinXRepository
{
    private readonly DemoDbContext _dbContext;

    public SalohiddinXRepository(DemoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<IEnumerable<SalohiddinX>> GetAllUsersAsync()
    {
        return await _dbContext.SalohiddinX.ToListAsync();
    }
}
