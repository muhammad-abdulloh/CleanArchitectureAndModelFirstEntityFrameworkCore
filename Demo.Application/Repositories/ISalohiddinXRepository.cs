using Demo.Domain.BaseModels.Entities;

namespace Demo.Application.Repositories;

public interface ISalohiddinXRepository
{
    public ValueTask<IEnumerable<SalohiddinX>> GetAllUsersAsync();
}
