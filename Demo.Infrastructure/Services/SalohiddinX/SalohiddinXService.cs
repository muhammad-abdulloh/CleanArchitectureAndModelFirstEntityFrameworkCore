using Demo.Application.Repositories;

namespace Demo.Infrastructure.Services.SalohiddinX;

public class SalohiddinXService : ISalohiddinXService
{
    private readonly ISalohiddinXRepository _repo;

    public SalohiddinXService(ISalohiddinXRepository xRepository)
    {
        _repo = xRepository;
    }

    public async ValueTask<IEnumerable<Domain.BaseModels.Entities.SalohiddinX>> GetAllUsersAsync()
        => await _repo.GetAllUsersAsync();
}