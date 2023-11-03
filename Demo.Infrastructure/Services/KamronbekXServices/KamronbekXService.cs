using Demo.Application.Repositories.KamronbekXRepositories;
using Demo.Domain.Models.KamronbekXModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Services.KamronbekXServices;

public class KamronbekXService : IKamronbekXService
{
    private readonly IKamronbekRepository kamronbekRepository;

    public KamronbekXService(IKamronbekRepository kamronbekRepository)
    {
        this.kamronbekRepository = kamronbekRepository;
    }

    public async ValueTask<IEnumerable<KamronbekX>> GetAllAsync()
    {
        IEnumerable<KamronbekX> entities = await kamronbekRepository.GetAllAsync();
        return entities;
    }
}
