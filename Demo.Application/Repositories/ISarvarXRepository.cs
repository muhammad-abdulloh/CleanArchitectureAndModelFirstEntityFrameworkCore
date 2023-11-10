using Demo.Domain.Models.SarvarXModel;

namespace Demo.Application.Repositories
{
    public interface ISarvarXRepository
    {
        public ValueTask<IEnumerable<SarvarX>> GetAllSarvarX();
    }
}
