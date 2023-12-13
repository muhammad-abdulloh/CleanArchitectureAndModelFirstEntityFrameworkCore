using Demo.Application.DataAcsess;
using Demo.Domain.Models.SarvarXModel;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Repositories
{
    public class SarvarXRepository : ISarvarXRepository
    {
        public readonly DemoDbContext _dbContext;
        public SarvarXRepository(DemoDbContext contect) 
        {
            _dbContext = contect;

        }

        public async ValueTask<IEnumerable<SarvarX>> GetAllSarvarX()
        {
            IEnumerable<SarvarX> sarvar = (IEnumerable<SarvarX>)await _dbContext.SarvarX.ToListAsync();

            return sarvar;
            
        }
    }
}
