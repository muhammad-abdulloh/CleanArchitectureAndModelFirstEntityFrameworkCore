using Demo.Domain.DTOs.KamronbekXDTOs;
using Demo.Domain.Models.KamronbekXModel;

namespace Demo.Application.Repositories.KamronbekXRepositories;

public interface IKamronbekRepository
{
    public ValueTask<IEnumerable<KamronbekX>> GetAllAsync();
}
